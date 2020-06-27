namespace BeeMindMap_UI.Views
{
    partial class MessageBoxUI_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(19)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel2.Location = new System.Drawing.Point(16, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 2);
            this.panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(116, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Message Box";
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.bt3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.Color.White;
            this.bt3.Location = new System.Drawing.Point(287, 140);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(87, 34);
            this.bt3.TabIndex = 18;
            this.bt3.Text = "Cancel";
            this.bt3.UseVisualStyleBackColor = false;
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(19)))), ((int)(((byte)(52)))));
            this.bt2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.Color.White;
            this.bt2.Location = new System.Drawing.Point(194, 140);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(87, 34);
            this.bt2.TabIndex = 18;
            this.bt2.Text = "Yes";
            this.bt2.UseVisualStyleBackColor = false;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(19)))), ((int)(((byte)(52)))));
            this.bt1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.White;
            this.bt1.Location = new System.Drawing.Point(101, 140);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(87, 34);
            this.bt1.TabIndex = 18;
            this.bt1.Text = "No";
            this.bt1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(362, 83);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "Thông tin sự kiện mesage Box sẽ nằm ở đây!";
            // 
            // MessageBoxUI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(381, 179);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxUI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxUI_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label lbTitle;
        public System.Windows.Forms.Button bt3;
        public System.Windows.Forms.Button bt2;
        public System.Windows.Forms.Button bt1;
    }
}