
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RichTextBox = System.Windows.Forms.RichTextBox;
using System.Drawing.Printing;

namespace BeeMindMap_UI.Raws
{
    public class RoundedSquare : Guna2Panel
    {
        public Guna.UI2.WinForms.Suite.Panel Main = new Guna.UI2.WinForms.Suite.Panel();
        public RichTextBox MainRichTextBox = new RichTextBox();
        public Color MainColor;
        public string Shape = "Circle";
        public string[] Shapes = new string[] { "Line", "Retangle", "Circle", "Ellipse", "Square", "Triangle", "Trapezium", "Hexagon" };
        public bool CanChangeSize;
        public bool CanMove;
        public bool NodeSelected;
        public bool FramesMouseDown;
        public bool MainMouseDown;
        public int Main_X;
        public int Main_Y;
        public int Frames_X;
        public int Frames_Y;
        public int SizeOfText;
        public Size SizeText;
        // định dạnh text
        public Color TextNodeColor = Color.Blue; // Màu sắc chữ
        public FontFamily TextNodeFontName = new FontFamily("Century Gothic");
        public int TextNodeFontSize = 20;
        public Font FontText;

        public RoundedSquare()
        {

            CanMove = false;
            CanChangeSize = false;
            FramesMouseDown = false;
            NodeSelected = false;
            FontText = new Font(TextNodeFontName, TextNodeFontSize);

            // Textbox in Main
            this.MaximumSize = new Size(400, 400);
            this.MinimumSize = new Size(200, 200);
            this.Size = MinimumSize;
            this.BorderStyle = DashStyle.Solid;
            this.BorderThickness = 3;
            this.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.BackColor = Color.FromArgb(0, 0, 0, 0);

            this.Controls.Add(Main);

            Main.Location = new Point(5, 5);
            Main.Size = new Size(this.Width - 10, this.Height - 10);
            Main.BackColor = Color.Gray;
            Main.Controls.Add(MainRichTextBox);



            MainRichTextBox.Text = "New Node";
            MainRichTextBox.Font = FontText;
            MainRichTextBox.Location = new Point();
            MainRichTextBox.ForeColor = TextNodeColor;
            MainRichTextBox.ReadOnly = true;
            MainRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MainRichTextBox.Cursor = Cursors.Arrow;
            MainRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            SizeText = TextRenderer.MeasureText(MainRichTextBox.Text, FontText);
            MainRichTextBox.Size = new Size(SizeText.Width, SizeText.Height);
            MainRichTextBox.BackColor = Main.BackColor;
            MainRichTextBox.Location = new Point((Main.Width - MainRichTextBox.Width) / 2, (Main.Height - MainRichTextBox.Height) / 2);
            MainRichTextBox.SelectAll();
            MainRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            MainRichTextBox.Multiline = false;




            MainRichTextBox.SelectAll();
            MainRichTextBox.SelectionAlignment = HorizontalAlignment.Center;


            Main.MouseDown += Main_MouseDown;
            Main.MouseMove += Main_MouseMove;
            Main.MouseUp += Main_MouseUp;
            Main.MouseLeave += Main_MouseLeave;
            Main.MouseHover += Main_MouseHover;
            Main.MouseDoubleClick += Main_MouseDoubleClick;

            MainRichTextBox.MouseDown += Main_MouseDown;
            MainRichTextBox.MouseMove += Main_MouseMove;
            MainRichTextBox.MouseUp += Main_MouseUp;
            MainRichTextBox.MouseLeave += Main_MouseLeave;
            MainRichTextBox.MouseHover += Main_MouseHover;
            MainRichTextBox.MouseDoubleClick += Main_MouseDoubleClick;
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath p = new GraphicsPath();
            this.Height = this.Width;
            p.AddPolygon(new Point[]{
                                            new Point(0,Main.Height/2),
                                            new Point(Main.Width/2,0),
                                            new Point(Main.Width,Main.Height/2),
                                            new Point(Main.Width/2,Main.Height)
                                                              });

            p.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
            p.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
            p.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
            p.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
            p.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
            p.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
            p.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
            p.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);

            Main.Region = new Region(p);
        }

        private void DrawNode_SizeChanged(object sender, EventArgs e)
        {

        }
        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            SizeText = TextRenderer.MeasureText(MainRichTextBox.Text, FontText);
            MainRichTextBox.Width = SizeText.Width;
            this.Width = SizeText.Width + 30;
            this.Height = this.Width;
            Main.Width = this.Width - 10;
            Main.Height = this.Height - 10;
            MainRichTextBox.Location = new Point((Main.Width - MainRichTextBox.Width) / 2, (Main.Height - MainRichTextBox.Height) / 2);
            if (this.Width < MaximumSize.Width && SizeText.Width < Main.Width - 20)
            {
                this.Width = SizeText.Width + 30;
                Main.Width = this.Width - 10;
                MainRichTextBox.Width = Main.Width - 20;

            }

            else
            if (SizeOfText < Main.Width - 20 && this.Width > this.MaximumSize.Width)
            {
                this.Width = SizeText.Width + 30;

                Main.Width = this.Width - 10;
                MainRichTextBox.Width = Main.Width - 20;
            }



        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MainRichTextBox.HideSelection = true;
            MainRichTextBox.ReadOnly = false;
            MainRichTextBox.SelectAll();
            MainRichTextBox.KeyDown += MainTextBox_KeyDown;
        }

        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainRichTextBox.ReadOnly = true;
                MainRichTextBox.HideSelection = false;
                MainRichTextBox.BackColor = Main.BackColor;
            }
        }

        private void Main_MouseHover(object sender, EventArgs e)
        {
            this.BorderColor = Color.FromArgb(150, 222, 255);
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
            if (NodeSelected == false)
                this.BorderColor = Color.FromArgb(0, 0, 0, 0);
        }



        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            CanMove = false;

        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanMove == true)
            {
                this.Left += e.X - Main_X;
                this.Top += e.Y - Main_Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            CanMove = true;
            NodeSelected = true;
            Main_X = e.X;
            Main_Y = e.Y;



        }

        #region Border


        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Frames_X = e.X;
            Frames_Y = e.Y;
            if (Frames_X >= this.Width - 7 && NodeSelected)
            {
                Cursor.Current = Cursors.SizeWE;
                CanChangeSize = true;

            }
            else
            {
                CanChangeSize = false;

            }
            if (FramesMouseDown)
                this.Width = (Frames_X);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (CanChangeSize && NodeSelected)
            {
                FramesMouseDown = true;
                CanMove = false;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (FramesMouseDown && CanMove == false)
            {
                FramesMouseDown = false;
                Main.Width = this.Width - 10 - this.BorderThickness * 2;
                this.Height = this.Width;
                Main.Height = this.Height - 10 - this.BorderThickness * 2;
                MainRichTextBox.Location = new Point((Main.Width - MainRichTextBox.Width) / 2, (Main.Height - MainRichTextBox.Height) / 2);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            NodeSelected = true;
            this.BorderColor = Color.CadetBlue;
            this.BorderThickness = 2;
        }

        #endregion
    }
}


