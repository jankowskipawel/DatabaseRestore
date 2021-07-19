using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string connString = $"Host={host};Username={username};Password={password};Database={databaseName}";
            await using var conn = new NpgsqlConnection(connString);
            await conn.OpenAsync();
            //get tables
            using (var cmd = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' ORDER BY table_name; ; ", conn))
            using (  var reader = cmd.ExecuteReader())
            {
                reader.Read();
                if (reader.HasRows)
                {
                    //check if database exists, if exists ask if continue or not
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
            //pg_restore -U postgres -h localhost -p 5432 -d baba -W -1 --disable-triggers E:\Downloads\test.backup
            //ADD postgres/bin to PATH
        }
    }
}
