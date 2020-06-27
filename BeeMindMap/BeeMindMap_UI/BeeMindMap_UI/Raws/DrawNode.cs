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
    public class DrawNode : Guna2Panel
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

        public DrawNode()
        {

            CanMove = false;
            CanChangeSize = false;
            FramesMouseDown = false;
            NodeSelected = false;
            FontText = new Font(TextNodeFontName, TextNodeFontSize);

            // Textbox in Main

            MainRichTextBox.BackColor = Main.BackColor;
            MainRichTextBox.Text = "New Node";
            MainRichTextBox.ForeColor = TextNodeColor;
            MainRichTextBox.Font = FontText;
            MainRichTextBox.ReadOnly = true;
            MainRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MainRichTextBox.Cursor = Cursors.Arrow;
            MainRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.HideSelection = false;
            MainRichTextBox.BackColor = Color.Gray;
            MainRichTextBox.SelectAll();
            
            MainRichTextBox.Margin = new Padding(0, 0, 0, 0);

            SizeText = TextRenderer.MeasureText(MainRichTextBox.Text, FontText);

            MainRichTextBox.Height = SizeText.Height;
            MainRichTextBox.Width = SizeText.Width;

            MainRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            MainRichTextBox.Multiline = true;



            //Panel Main
            Main.Width = SizeText.Width + 10;
            Main.Height = SizeText.Height + 10;
            Main.BackColor = Color.Gray;
            Main.Dock = DockStyle.Fill;
            Main.Controls.Add(MainRichTextBox);
            Main.Padding = new Padding(this.Width / 15, this.Width/3, this.Width / 15, this.Width/3);
            Main.Controls.Add(MainRichTextBox);

            //Boder
            this.BorderStyle = DashStyle.Solid;
            this.BorderThickness = 3;
            this.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.BackColor   = Color.FromArgb(0, 0, 0, 0);
            this.Padding = new Padding(5, 5, 5, 5);
            this.Controls.Add(Main);
            


            

            







            

           

/*            SetShape(Shape);*/




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
            MainRichTextBox.TextChanged += MainTextBox_TextChanged;


        }


/*        public void SetShape(string shape)
        {
            switch (shape)
            {
                case "Line":
                    break;
                case "Retangle":
                    CutRectangle();
                    break;
                case "Circle":
                    CutCircle();
                    break;
                case "Ellipse":
                    break;
                case "Square":
                    break;
                case "Triangle":
                    break;
                case "Trapezium":
                    break;
                case "Hexagon":
                    break;
            }
        }
        private void CutCircle()
        {
            
            
            GraphicsPath p = new GraphicsPath();
            this.Height = this.Width;
            p.AddEllipse(0, 0, Main.Width, Main.Width);
            Main.Region = new Region(p);
            

*//*            Main.MouseDown += Main_MouseDown;
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
            MainRichTextBox.TextChanged += MainTextBox_TextChanged;*//*

        }



        private void CutSquare()
        {

        }
        #region Hình chữ nhật
        private void CutRectangle()
        {

            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            *//* Main.Width = 180;
             MainTextBox.Width = Main.Width - 10;
             Main.Height = MainTextBox.Height + 10; 
             this.Width = 180 + 10 + BorderThickness * 2;
             this.Height = Main.Height + 10 + BorderThickness * 2;                    
             Main.Location = new Point(this.Location.X+  5 + this.BorderThickness, this.Location.Y + 5 + this.BorderThickness);
             MainTextBox.Location = new Point(5, 5);
             MainTextBox.HideSelection = false;*//*

           


            // xử lí sự kiện


        }*/


        private void DrawNode_SizeChanged(object sender, EventArgs e)
        {

        }
        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            SizeText = TextRenderer.MeasureText(MainRichTextBox.Text, FontText);
            SizeOfText = SizeText.Width;
            if (SizeOfText > MainRichTextBox.Width && SizeText.Width < 400)
            {
                MainRichTextBox.Width = SizeText.Width;
                this.Width = Main.Width + 10 + BorderThickness * 2;
            }
            else
                if (SizeOfText < 170 && Main.Width > 180)
            {
                this.Width = 190 + BorderThickness * 2;
                Main.Width = 180;
                MainRichTextBox.Width = Main.Width - 10;
            }
            else
                if (SizeOfText > MainRichTextBox.Width && SizeText.Width > 400)
                this.Height = this.Height + (SizeText.Height + 3)*(SizeText.Width / 400 -1); 
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainRichTextBox.BackColor = Color.White;
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
                this.BorderColor = Color.FromArgb(0,0,0,0);
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


        private void CanChangeSizeWith(String K)
        { 


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
                this.Width = (Frames_X );
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
