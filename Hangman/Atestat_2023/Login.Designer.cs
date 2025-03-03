
namespace Atestat_2023
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_conectare = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(95, 129);
            this.label_username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(174, 39);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(72, 179);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(521, 39);
            this.textBox_username.TabIndex = 1;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(95, 233);
            this.label_password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(167, 39);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(72, 282);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(521, 39);
            this.textBox_password.TabIndex = 3;
            // 
            // button_conectare
            // 
            this.button_conectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_conectare.Location = new System.Drawing.Point(350, 439);
            this.button_conectare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_conectare.Name = "button_conectare";
            this.button_conectare.Size = new System.Drawing.Size(246, 59);
            this.button_conectare.TabIndex = 4;
            this.button_conectare.Text = "Connect";
            this.button_conectare.UseVisualStyleBackColor = true;
            this.button_conectare.Click += new System.EventHandler(this.button_conectare_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(72, 439);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(246, 59);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 587);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_conectare);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_conectare;
        private System.Windows.Forms.Button button_cancel;
    }
}