namespace BeeMindMap_UI.Views
{
    partial class TreeUI_Form
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
            this.pnBeeTreeView = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbStyle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbfont = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnTopTool = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.beeTreeView = new System.Windows.Forms.TreeView();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnBeeTreeView.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnTopTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBeeTreeView
            // 
            this.pnBeeTreeView.BackColor = System.Drawing.Color.White;
            this.pnBeeTreeView.Controls.Add(this.pnTool);
            this.pnBeeTreeView.Controls.Add(this.panel6);
            this.pnBeeTreeView.Controls.Add(this.beeTreeView);
            this.pnBeeTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnBeeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBeeTreeView.Location = new System.Drawing.Point(0, 0);
            this.pnBeeTreeView.Name = "pnBeeTreeView";
            this.pnBeeTreeView.Size = new System.Drawing.Size(1479, 650);
            this.pnBeeTreeView.TabIndex = 1;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.pnTool.Controls.Add(this.lbSize);
            this.pnTool.Controls.Add(this.lbStyle);
            this.pnTool.Controls.Add(this.textBox1);
            this.pnTool.Controls.Add(this.button1);
            this.pnTool.Controls.Add(this.lbfont);
            this.pnTool.Controls.Add(this.label4);
            this.pnTool.Controls.Add(this.label3);
            this.pnTool.Controls.Add(this.pnTopTool);
            this.pnTool.Location = new System.Drawing.Point(51, 118);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(251, 38);
            this.pnTool.TabIndex = 6;
            this.pnTool.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTool_Paint);
            // 
            // lbSize
            // 
            this.lbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.lbSize.Location = new System.Drawing.Point(66, 116);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(173, 25);
            this.lbSize.TabIndex = 7;
            this.lbSize.Text = "size . . .";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSize.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbStyle
            // 
            this.lbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.lbStyle.Location = new System.Drawing.Point(66, 83);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(173, 25);
            this.lbStyle.TabIndex = 6;
            this.lbStyle.Text = "style . . .";
            this.lbStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStyle.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(96, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 19);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(64, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbfont
            // 
            this.lbfont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbfont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.lbfont.Location = new System.Drawing.Point(66, 50);
            this.lbfont.Name = "lbfont";
            this.lbfont.Size = new System.Drawing.Size(173, 25);
            this.lbfont.TabIndex = 3;
            this.lbfont.Text = "font . . .";
            this.lbfont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbfont.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label4.Location = new System.Drawing.Point(2, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Color :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Font :";
            this.label3.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnTopTool
            // 
            this.pnTopTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnTopTool.Controls.Add(this.label2);
            this.pnTopTool.Controls.Add(this.label1);
            this.pnTopTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopTool.Location = new System.Drawing.Point(0, 0);
            this.pnTopTool.Name = "pnTopTool";
            this.pnTopTool.Size = new System.Drawing.Size(251, 38);
            this.pnTopTool.TabIndex = 0;
            this.pnTopTool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopTool_MouseDown);
            this.pnTopTool.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopTool_MouseMove);
            this.pnTopTool.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTool_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(219, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "^";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Format";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.panel6.Location = new System.Drawing.Point(39, 647);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1405, 3);
            this.panel6.TabIndex = 5;
            // 
            // beeTreeView
            // 
            this.beeTreeView.AllowDrop = true;
            this.beeTreeView.BackColor = System.Drawing.Color.White;
            this.beeTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beeTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beeTreeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.beeTreeView.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beeTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.beeTreeView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.beeTreeView.ItemHeight = 30;
            this.beeTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.beeTreeView.Location = new System.Drawing.Point(372, 0);
            this.beeTreeView.Name = "beeTreeView";
            this.beeTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.beeTreeView.Size = new System.Drawing.Size(1107, 650);
            this.beeTreeView.TabIndex = 0;
            this.beeTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.beeTreeView_AfterLabelEdit);
            this.beeTreeView.Click += new System.EventHandler(this.beeTreeView_Click);
            this.beeTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beeTreeView_KeyDown);
            this.beeTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.beeTreeView_MouseDown);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.DarkRed;
            // 
            // TreeUI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1479, 650);
            this.Controls.Add(this.pnBeeTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreeUI_Form";
            this.Text = "TreeUI_Form";
            this.pnBeeTreeView.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            this.pnTopTool.ResumeLayout(false);
            this.pnTopTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBeeTreeView;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TreeView beeTreeView;
        public System.Windows.Forms.SaveFileDialog saveFile;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Panel pnTopTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbfont;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbStyle;
    }
}