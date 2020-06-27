namespace BeeMindMap_UI.Views
{
    partial class ViewUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Size = new System.Drawing.Size(26, 120);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(31, 54);
            this.panel2.Size = new System.Drawing.Size(175, 120);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(-1, 93);
            this.button4.Size = new System.Drawing.Size(176, 23);
            this.button4.Text = "Zoom Out (Ctrl-)";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(-1, 64);
            this.button3.Size = new System.Drawing.Size(176, 23);
            this.button3.Text = "Zoom In (Ctrl+)";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(0, 35);
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.Text = "Format";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.Text = "Slideshow Mode";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::BeeMindMap_UI.Properties.Resources.zoom_out_50px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(1, 93);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BeeMindMap_UI.Properties.Resources.zoom_in_50px;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1, 64);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BeeMindMap_UI.Properties.Resources.paint_brush_50px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1, 35);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BeeMindMap_UI.Properties.Resources.tv_show_50px;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 54);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(31, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 2);
            this.panel4.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(0, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(206, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "    View Tree";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "    View Map";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // ViewUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Button1 = "Slideshow Mode";
            this.Button2 = "Format";
            this.Button3 = "Zoom In (Ctrl+)";
            this.Button4 = "Zoom Out (Ctrl-)";
            this.Controls.Add(this.panel3);
            this.Name = "ViewUI";
            this.Size = new System.Drawing.Size(206, 174);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel4;
    }
}
