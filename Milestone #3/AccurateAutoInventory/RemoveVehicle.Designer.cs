namespace AccurateAutoInventory
{
    partial class RemoveVehicle
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
            this.Menu2 = new System.Windows.Forms.Button();
            this.Quit2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu2
            // 
            this.Menu2.BackColor = System.Drawing.SystemColors.GrayText;
            this.Menu2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu2.Location = new System.Drawing.Point(15, 306);
            this.Menu2.Margin = new System.Windows.Forms.Padding(4);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(181, 54);
            this.Menu2.TabIndex = 0;
            this.Menu2.Text = "Main Menu";
            this.Menu2.UseVisualStyleBackColor = false;
            this.Menu2.Click += new System.EventHandler(this.Menu2_Click);
            // 
            // Quit2
            // 
            this.Quit2.BackColor = System.Drawing.Color.Maroon;
            this.Quit2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quit2.Location = new System.Drawing.Point(204, 306);
            this.Quit2.Margin = new System.Windows.Forms.Padding(4);
            this.Quit2.Name = "Quit2";
            this.Quit2.Size = new System.Drawing.Size(181, 54);
            this.Quit2.TabIndex = 1;
            this.Quit2.Text = "Quit";
            this.Quit2.UseVisualStyleBackColor = false;
            this.Quit2.Click += new System.EventHandler(this.Quit2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(15, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 68);
            this.button1.TabIndex = 23;
            this.button1.Text = "Remove Selected Vehicle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(15, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 28);
            this.textBox1.TabIndex = 22;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label.Location = new System.Drawing.Point(11, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(184, 20);
            this.label.TabIndex = 21;
            this.label.Text = "Enter Stock Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-89, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 46);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(25, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(340, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Text visable when Success or Error Message";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 68);
            this.listBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selected vehicle matching stock number:";
            // 
            // RemoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Quit2);
            this.Controls.Add(this.Menu2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveVehicle";
            this.Text = "RemoveVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menu2;
        private System.Windows.Forms.Button Quit2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}