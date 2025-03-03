
namespace Atestat_2023
{
    partial class Admin
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
            this.label_cuvant = new System.Windows.Forms.Label();
            this.textBox_cuvant = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_cuvant
            // 
            this.label_cuvant.AutoSize = true;
            this.label_cuvant.BackColor = System.Drawing.Color.Transparent;
            this.label_cuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuvant.Location = new System.Drawing.Point(57, 94);
            this.label_cuvant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_cuvant.Name = "label_cuvant";
            this.label_cuvant.Size = new System.Drawing.Size(107, 39);
            this.label_cuvant.TabIndex = 0;
            this.label_cuvant.Text = "Word:";
            // 
            // textBox_cuvant
            // 
            this.textBox_cuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cuvant.Location = new System.Drawing.Point(202, 94);
            this.textBox_cuvant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_cuvant.Name = "textBox_cuvant";
            this.textBox_cuvant.Size = new System.Drawing.Size(516, 39);
            this.textBox_cuvant.TabIndex = 1;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(64, 251);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(306, 68);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_cuvant);
            this.Controls.Add(this.label_cuvant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cuvant;
        private System.Windows.Forms.TextBox textBox_cuvant;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button1;
    }
}