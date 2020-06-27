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
using TextBox = System.Windows.Forms.TextBox;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace BeeMindMap_UI.Raws
{
    public class Circle : Guna2Panel
    {
        public Guna.UI2.WinForms.Suite.Panel Main = new Guna.UI2.WinForms.Suite.Panel();
        public TextBox MainTextBox = new TextBox();


        public bool CanChangeSize;
        public bool CanMove;
        public bool FramesMouseDown;
        public bool MainMouseDown;
        public int Main_X;
        public int Main_Y;
        public int Frames_X;
        public int Frames_Y;
        public int SizeOfText;
        public Size Sizetext;




        public Font FontText;
        // Thuộc tính
        public string Shape;
        public Color TextNodeColor = Color.FromArgb(0, 0, 0, 0);
        public int TextNodeFontSize = 0;
        public FontFamily TextNodeFontName = new FontFamily("Century Gothic");
        public Color MainColor = Color.FromArgb(0, 0, 0, 0);
        public bool NodeSelected;
        public Size SizeNode = new Size(0, 0);
        public String TextNode = "";

        public List<string> infomation = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };

        public Circle()
        {
            this.MaximumSize = new Size(600, 600);
            this.MinimumSize = new Size(200, 200);

            Shape = "Retangle";
            if (TextNodeColor == Color.FromArgb(0, 0, 0, 0))
                TextNodeColor = Color.Blue;
            if (TextNodeFontSize == 0)
                TextNodeFontSize = 20;
            if (TextNodeFontName == new FontFamily("Century Gothic"))
            { }
            if (MainColor == Color.FromArgb(0, 0, 0, 0))
                MainColor = Color.Gray;
            if (SizeNode == new Size(0, 0))
                SizeNode = this.MinimumSize;
            if (TextNode == "")
                TextNode = "New node";

            CanMove = false;
            CanChangeSize = false;
            FramesMouseDown = false;
            NodeSelected = false;
            FontText = new Font(TextNodeFontName, TextNodeFontSize);

            // Textbox in Main

            this.Size = MinimumSize;
            this.BorderStyle = DashStyle.Solid;
            this.BorderThickness = 3;
            this.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.BackColor = Color.FromArgb(0, 0, 0, 0);

            this.Controls.Add(Main);

            Main.Location = new Point(5, 5);
            Main.Size = new Size(this.Width - 10, this.Height - 10);
            Main.BackColor = MainColor;
            Main.Controls.Add(MainTextBox);



            MainTextBox.Text = TextNode;
            MainTextBox.Font = FontText;
            MainTextBox.Width = Main.Width;
            MainTextBox.ForeColor = TextNodeColor;
            MainTextBox.ReadOnly = true;
            MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MainTextBox.Cursor = Cursors.Arrow;
            MainTextBox.TextAlign = HorizontalAlignment.Center;
            Sizetext = TextRenderer.MeasureText(MainTextBox.Text, FontText);
            MainTextBox.Location = new Point(0, (Main.Height - Sizetext.Height) / 2);
            MainTextBox.BackColor = Main.BackColor;




            Main.MouseDown += Main_MouseDown;
            Main.MouseMove += Main_MouseMove;
            Main.MouseUp += Main_MouseUp;
            Main.MouseLeave += Main_MouseLeave;
            Main.MouseHover += Main_MouseHover;
            Main.MouseDoubleClick += Main_MouseDoubleClick;

            MainTextBox.MouseDown += Main_MouseDown;
            MainTextBox.MouseMove += Main_MouseMove;
            MainTextBox.MouseUp += Main_MouseUp;
            MainTextBox.MouseLeave += Main_MouseLeave;
            MainTextBox.MouseHover += Main_MouseHover;
            MainTextBox.MouseDoubleClick += Main_MouseDoubleClick;
            MainTextBox.TextChanged += MainTextBox_TextChanged;
            MainTextBox.SizeChanged += MainTextBox_SizeChanged;

            infomation[1] = "Retangle";
            infomation[2] = this.Location.X.ToString();
            infomation[3] = this.Location.Y.ToString();
            infomation[4] = this.BackColor.A.ToString();
            infomation[5] = this.BackColor.R.ToString();
            infomation[6] = this.BackColor.G.ToString();
            infomation[7] = this.BackColor.B.ToString();
            infomation[8] = this.ForeColor.A.ToString();
            infomation[9] = this.ForeColor.R.ToString();
            infomation[10] = this.ForeColor.G.ToString();
            infomation[11] = this.ForeColor.B.ToString();
            infomation[12] = this.Width.ToString();
            infomation[13] = this.Height.ToString();
            infomation[14] = this.TextNodeFontSize.ToString();
            infomation[15] = this.TextNodeFontName.Name.ToString();
            infomation[16] = this.TextNode;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath p = new GraphicsPath();
            this.Height = this.Width;
            p.AddEllipse(0, 0, Main.Width, Main.Width);
            Main.Region = new Region(p);
        }

        private void MainTextBox_SizeChanged(object sender, EventArgs e)
        {
            infomation[12] = this.Width.ToString();
            infomation[13] = this.Height.ToString();
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            Sizetext = TextRenderer.MeasureText(MainTextBox.Text, FontText);
            if (Sizetext.Width > MainTextBox.Width)
            {
                MainTextBox.Width = Sizetext.Width;
                Main.Width = Sizetext.Width;
                Main.Height = Main.Height;
                this.Width = Main.Width + 10 ;
                this.Height = this.Height + 10 ;
                MainTextBox.Location = new Point (0, (Main.Height - MainTextBox.Height) /2);
                MainTextBox.SelectAll();
                MainTextBox.TextAlign = HorizontalAlignment.Center;
                infomation[16] = MainTextBox.Text;
            }
            else
                if (Sizetext.Width < Main.Width && Main.Width > this.MinimumSize.Width - 10 && this.Main.Width > this.MinimumSize.Width - 10)
            {
                MainTextBox.Width = Sizetext.Width;
                Main.Width = MainTextBox.Width;
                this.Width = Main.Width + 10;

                MainTextBox.SelectAll();
                MainTextBox.TextAlign = HorizontalAlignment.Center;
                infomation[16] = MainTextBox.Text;
            }
            else
               if (Sizetext.Width < Main.Width && Main.Width < this.MinimumSize.Width - 10 && this.Main.Width > this.MinimumSize.Width - 10)
            {
                this.Width = this.MinimumSize.Width;
                Main.Width = this.Width - 10;
                MainTextBox.Width = Main.Width;
                MainTextBox.SelectAll();
                MainTextBox.TextAlign = HorizontalAlignment.Center;
                infomation[16] = MainTextBox.Text;
            }




        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MainTextBox.HideSelection = true;
            MainTextBox.ReadOnly = false;
            MainTextBox.SelectAll();
            MainTextBox.KeyDown += MainTextBox_KeyDown;
        }

        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainTextBox.ReadOnly = true;
                MainTextBox.HideSelection = false;
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




        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Frames_X = e.X;
            Frames_Y = e.Y;
            if (Frames_X >= this.Width - 3 && NodeSelected)
            {
                Cursor.Current = Cursors.SizeWE;
                CanChangeSize = true;
                NodeSelected = true;
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
                Main.Width = this.Width - 10;
                MainTextBox.Width = Main.Width;
                Main.Height = this.Height -10 ;
                MainTextBox.Location = new Point(0, (Main.Height - MainTextBox.Height) / 2);
                MainTextBox.SelectAll();
                MainTextBox.TextAlign = HorizontalAlignment.Center;
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            NodeSelected = true;
            this.BorderColor = Color.CadetBlue;
            this.BorderThickness = 3;
        }

    }
}
