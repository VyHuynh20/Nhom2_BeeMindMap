namespace BeeMindMap_UI.Views
{
    partial class MapUI_Form
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
            this.pnTool = new System.Windows.Forms.Panel();
            this.pnSelect_Tool = new System.Windows.Forms.Panel();
            this.pnStyle = new System.Windows.Forms.Panel();
            this.btStyle = new System.Windows.Forms.Button();
            this.pnMap = new System.Windows.Forms.Panel();
            this.btMap = new System.Windows.Forms.Button();
            this.pnTool_List = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnTool.SuspendLayout();
            this.pnSelect_Tool.SuspendLayout();
            this.pnStyle.SuspendLayout();
            this.pnMap.SuspendLayout();
            this.pnTool_List.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(182)))));
            this.pnTool.Controls.Add(this.pnSelect_Tool);
            this.pnTool.Controls.Add(this.pnTool_List);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTool.Location = new System.Drawing.Point(1179, 0);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(300, 650);
            this.pnTool.TabIndex = 1;
            this.pnTool.Resize += new System.EventHandler(this.pnTool_Resize);
            // 
            // pnSelect_Tool
            // 
            this.pnSelect_Tool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSelect_Tool.AutoSize = true;
            this.pnSelect_Tool.Controls.Add(this.pnStyle);
            this.pnSelect_Tool.Controls.Add(this.pnMap);
            this.pnSelect_Tool.Location = new System.Drawing.Point(0, 0);
            this.pnSelect_Tool.Name = "pnSelect_Tool";
            this.pnSelect_Tool.Size = new System.Drawing.Size(300, 33);
            this.pnSelect_Tool.TabIndex = 0;
            // 
            // pnStyle
            // 
            this.pnStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnStyle.Controls.Add(this.btStyle);
            this.pnStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStyle.Location = new System.Drawing.Point(0, 0);
            this.pnStyle.Name = "pnStyle";
            this.pnStyle.Size = new System.Drawing.Size(150, 33);
            this.pnStyle.TabIndex = 1;
            // 
            // btStyle
            // 
            this.btStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStyle.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btStyle.FlatAppearance.BorderSize = 0;
            this.btStyle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btStyle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(130)))));
            this.btStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStyle.Location = new System.Drawing.Point(0, 0);
            this.btStyle.Name = "btStyle";
            this.btStyle.Size = new System.Drawing.Size(150, 33);
            this.btStyle.TabIndex = 0;
            this.btStyle.Text = "Style";
            this.btStyle.UseVisualStyleBackColor = false;
            this.btStyle.Click += new System.EventHandler(this.btStyle_Click);
            // 
            // pnMap
            // 
            this.pnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMap.Controls.Add(this.btMap);
            this.pnMap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMap.Location = new System.Drawing.Point(150, 0);
            this.pnMap.Name = "pnMap";
            this.pnMap.Size = new System.Drawing.Size(150, 33);
            this.pnMap.TabIndex = 0;
            // 
            // btMap
            // 
            this.btMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btMap.FlatAppearance.BorderSize = 0;
            this.btMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(130)))));
            this.btMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMap.Location = new System.Drawing.Point(0, 0);
            this.btMap.Name = "btMap";
            this.btMap.Size = new System.Drawing.Size(150, 33);
            this.btMap.TabIndex = 0;
            this.btMap.Text = "Map";
            this.btMap.UseVisualStyleBackColor = false;
            this.btMap.Click += new System.EventHandler(this.btMap_Click);
            // 
            // pnTool_List
            // 
            this.pnTool_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnTool_List.Controls.Add(this.panel2);
            this.pnTool_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTool_List.Location = new System.Drawing.Point(0, 33);
            this.pnTool_List.Name = "pnTool_List";
            this.pnTool_List.Size = new System.Drawing.Size(300, 617);
            this.pnTool_List.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.panel2.Location = new System.Drawing.Point(24, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 3);
            this.panel2.TabIndex = 5;
            // 
            // panelMap
            // 
            this.panelMap.AutoScroll = true;
            this.panelMap.AutoSize = true;
            this.panelMap.Controls.Add(this.panel6);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1179, 650);
            this.panelMap.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(47)))));
            this.panel6.Location = new System.Drawing.Point(39, 647);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1100, 3);
            this.panel6.TabIndex = 4;
            // 
            // MapUI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1479, 650);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.pnTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapUI_Form";
            this.Text = "MapUI_Form";
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            this.pnSelect_Tool.ResumeLayout(false);
            this.pnStyle.ResumeLayout(false);
            this.pnMap.ResumeLayout(false);
            this.pnTool_List.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnSelect_Tool;
        private System.Windows.Forms.Panel pnStyle;
        private System.Windows.Forms.Panel pnMap;
        private System.Windows.Forms.Button btStyle;
        private System.Windows.Forms.Button btMap;
        public System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnTool_List;
        public System.Windows.Forms.Panel panelMap;
    }
}