using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseRestore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backupPathButton_Click(object sender, EventArgs e)
        {
            backupFileDialog.ShowDialog();
            backupPathTextBox.Text = backupFileDialog.FileName;
        }

        private async void restoreDatabaseButton_Click(object sender, EventArgs e)
        {
            string host = ipTextBox.Text;
            string username = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string databaseName = databaseNameTextBox.Text;
            string backupPath = backupPathTextBox.Text;
            string portStr = portTextBox.Text;
            string connString = $"Host={host};Username={username};Password={password};Database={databaseName}";
            try
            {
                var port=0;
                Int32.TryParse(portStr, out port);
                CheckFilePath(backupPath);
                await using var conn = new NpgsqlConnection(connString);
                await conn.OpenAsync();
                //check if database is empty
                using (var cmd = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' ORDER BY table_name; ; ", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader.HasRows)
                    {
                        DialogResult dialogResult = MessageBox.Show("Database is not empty. Do you want to continue?", "Database restore", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                //remove schema public cascade
                using (var cmd1 = new NpgsqlCommand("DROP SCHEMA public CASCADE", conn))
                {
                    cmd1.ExecuteNonQuery();
                }
                //add schema public
                using (var cmd1 = new NpgsqlCommand("CREATE SCHEMA public", conn))
                {
                    cmd1.ExecuteNonQuery();
                }
                //use pg_restore to restore database
                List<string> commands = new List<string>(2);
                string cmdText = $"pg_restore -U {username} -h {host} -p {port} -d {databaseName} -1 --disable-triggers {backupPath}";
                commands.Add($"set \"PGPASSWORD={password}\"");
                commands.Add(cmdText);
                RunCommands(commands);
                MessageBox.Show("Database restored successfully");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        static void RunCommands(List<string> cmds, string workingDirectory = "")
        {
            var process = new Process();
            var psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.WorkingDirectory = workingDirectory;
            process.StartInfo = psi;
            process.Start();
            process.OutputDataReceived += (sender, e) => { Console.WriteLine(e.Data); };
            process.ErrorDataReceived += (sender, e) => { Console.WriteLine(e.Data); };
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            using (StreamWriter sw = process.StandardInput)
            {
                foreach (var cmd in cmds)
                {
                    sw.WriteLine(cmd);
                }
            }
            process.WaitForExit();
        }

        public static void CheckFilePath(string path)
        {
            if (path.Length == 0)
            {
                throw new ArgumentException("File path cannot be empty");
            }

            if (!File.Exists(path) || !IsPathValid(path))
            {
                throw new ArgumentException($"{path} is not a valid file");
            }
        }

        public static bool IsPathValid(string filePath)
        {
            HashSet<char> invalidCharacters = new HashSet<char>(Path.GetInvalidPathChars());
            return !string.IsNullOrEmpty(filePath) && !filePath.Any(pc => invalidCharacters.Contains(pc));
        }
    }
}
