
namespace Atestat_2023
{
    partial class Joc
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
            this.button_joc_nou = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_username = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_joc_nou
            // 
            this.button_joc_nou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_joc_nou.Location = new System.Drawing.Point(1060, 690);
            this.button_joc_nou.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_joc_nou.Name = "button_joc_nou";
            this.button_joc_nou.Size = new System.Drawing.Size(251, 85);
            this.button_joc_nou.TabIndex = 0;
            this.button_joc_nou.Text = "New Game";
            this.button_joc_nou.UseVisualStyleBackColor = true;
            this.button_joc_nou.Click += new System.EventHandler(this.button_joc_nou_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(616, 622);
            this.dataGridView1.TabIndex = 1;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(669, 153);
            this.label_username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(339, 55);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Welcome back";
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(728, 690);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(251, 85);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(187, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hall of fame";
            // 
            // Joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 801);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_joc_nou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Joc_FormClosing);
            this.Load += new System.EventHandler(this.Joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_joc_nou;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
    }
}