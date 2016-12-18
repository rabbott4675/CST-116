namespace AccurateAutoInventory
{
    partial class Purge
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PButton = new System.Windows.Forms.Button();
            this.Menu5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Quit5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 28);
            this.textBox1.TabIndex = 0;
            // 
            // PButton
            // 
            this.PButton.BackColor = System.Drawing.Color.ForestGreen;
            this.PButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PButton.Location = new System.Drawing.Point(13, 120);
            this.PButton.Margin = new System.Windows.Forms.Padding(4);
            this.PButton.Name = "PButton";
            this.PButton.Size = new System.Drawing.Size(370, 64);
            this.PButton.TabIndex = 1;
            this.PButton.Text = "Purge";
            this.PButton.UseVisualStyleBackColor = false;
            this.PButton.Click += new System.EventHandler(this.PButton_Click);
            // 
            // Menu5
            // 
            this.Menu5.BackColor = System.Drawing.SystemColors.GrayText;
            this.Menu5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu5.Location = new System.Drawing.Point(14, 192);
            this.Menu5.Margin = new System.Windows.Forms.Padding(4);
            this.Menu5.Name = "Menu5";
            this.Menu5.Size = new System.Drawing.Size(181, 54);
            this.Menu5.TabIndex = 2;
            this.Menu5.Text = "Main Menu";
            this.Menu5.UseVisualStyleBackColor = false;
            this.Menu5.Click += new System.EventHandler(this.Menu5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter password";
            // 
            // Quit5
            // 
            this.Quit5.BackColor = System.Drawing.Color.Maroon;
            this.Quit5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quit5.Location = new System.Drawing.Point(202, 192);
            this.Quit5.Margin = new System.Windows.Forms.Padding(4);
            this.Quit5.Name = "Quit5";
            this.Quit5.Size = new System.Drawing.Size(181, 54);
            this.Quit5.TabIndex = 4;
            this.Quit5.Text = "Quit";
            this.Quit5.UseVisualStyleBackColor = false;
            this.Quit5.Click += new System.EventHandler(this.Quit5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-88, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 47);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(117, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(340, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Text visable when Success or Error Message";
            // 
            // Purge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Quit5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu5);
            this.Controls.Add(this.PButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purge";
            this.Text = "Purge";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PButton;
        private System.Windows.Forms.Button Menu5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quit5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}