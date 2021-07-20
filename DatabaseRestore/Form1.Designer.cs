
namespace DatabaseRestore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.backupPathTextBox = new System.Windows.Forms.TextBox();
            this.backupPathButton = new System.Windows.Forms.Button();
            this.restoreDatabaseButton = new System.Windows.Forms.Button();
            this.backupFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.databaseNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pgrestoreFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(25, 35);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(240, 23);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP/server name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Backup file location:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(271, 35);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(35, 23);
            this.portTextBox.TabIndex = 6;
            this.portTextBox.Text = "5432";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(25, 84);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(138, 23);
            this.loginTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(169, 83);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(134, 23);
            this.passwordTextBox.TabIndex = 8;
            // 
            // backupPathTextBox
            // 
            this.backupPathTextBox.Location = new System.Drawing.Point(25, 178);
            this.backupPathTextBox.Name = "backupPathTextBox";
            this.backupPathTextBox.Size = new System.Drawing.Size(249, 23);
            this.backupPathTextBox.TabIndex = 9;
            // 
            // backupPathButton
            // 
            this.backupPathButton.Location = new System.Drawing.Point(281, 178);
            this.backupPathButton.Name = "backupPathButton";
            this.backupPathButton.Size = new System.Drawing.Size(25, 23);
            this.backupPathButton.TabIndex = 10;
            this.backupPathButton.Text = "...";
            this.backupPathButton.UseVisualStyleBackColor = true;
            this.backupPathButton.Click += new System.EventHandler(this.backupPathButton_Click);
            // 
            // restoreDatabaseButton
            // 
            this.restoreDatabaseButton.Location = new System.Drawing.Point(102, 221);
            this.restoreDatabaseButton.Name = "restoreDatabaseButton";
            this.restoreDatabaseButton.Size = new System.Drawing.Size(127, 23);
            this.restoreDatabaseButton.TabIndex = 11;
            this.restoreDatabaseButton.Text = "Restore database";
            this.restoreDatabaseButton.UseVisualStyleBackColor = true;
            this.restoreDatabaseButton.Click += new System.EventHandler(this.restoreDatabaseButton_Click);
            // 
            // backupFileDialog
            // 
            this.backupFileDialog.FileName = "openFileDialog1";
            // 
            // databaseNameTextBox
            // 
            this.databaseNameTextBox.Location = new System.Drawing.Point(25, 131);
            this.databaseNameTextBox.Name = "databaseNameTextBox";
            this.databaseNameTextBox.Size = new System.Drawing.Size(278, 23);
            this.databaseNameTextBox.TabIndex = 12;
            this.databaseNameTextBox.Text = "postgres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Database name:";
            // 
            // pgrestoreFileDialog
            // 
            this.pgrestoreFileDialog.FileName = "pg_restore.exe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 256);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.databaseNameTextBox);
            this.Controls.Add(this.restoreDatabaseButton);
            this.Controls.Add(this.backupPathButton);
            this.Controls.Add(this.backupPathTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.Name = "Form1";
            this.Text = "Database restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox backupPathTextBox;
        private System.Windows.Forms.Button backupPathButton;
        private System.Windows.Forms.Button restoreDatabaseButton;
        private System.Windows.Forms.OpenFileDialog backupFileDialog;
        private System.Windows.Forms.TextBox databaseNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog pgrestoreFileDialog;
    }
}

