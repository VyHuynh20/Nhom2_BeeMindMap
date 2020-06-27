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
using System.ComponentModel;
using BeeMindMap_UI.Views;

namespace BeeMindMap_UI.Models
{
    public partial class CustomMapNode : Guna2Panel
    {
        public System.Windows.Forms.Panel line1 = new System.Windows.Forms.Panel();
        public System.Windows.Forms.Panel line2 = new System.Windows.Forms.Panel();
        public System.Windows.Forms.Panel line3 = new System.Windows.Forms.Panel();
        public System.Windows.Forms.Panel Main = new System.Windows.Forms.Panel();
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
        public string Shape;
        public Color TextNodeColor;
        public int TextNodeFontSize;
        public string TextNodeFontName;
        public Color MainColor;
        public bool NodeSelected;
        public Size SizeNode;
        public String TextNode;
        public string ID;
        public string Information;
        public string[] Node_information = new string[20];


        [Category("text"), Description("node")]
        public string shape
        {
            get { return this.Shape; }
            set
            {
                this.Shape = value;
            }
        }
        public string TextFontName
        {
            get { return TextNodeFontName; }
            set { this.TextFontName = value; }
        }
        public int TextSize
        {
            get { return TextSize; }
            set { this.TextNodeFontSize = value; }
        }
        public Color NodeBackColor
        {
            get { return this.MainColor; }
            set { this.MainColor = value; }
        }
        public Color ColorText
        {
            get { return this.TextNodeColor; }
            set { this.TextNodeColor = value; }
        }
        public CustomMapNode()
        {
            Point location = new Point(0, 0);
            Size size = new Size(50, 100);
            Color NodeBackColor = Color.FromArgb(50, 15, 47);
            Color forecolor = Color.FromArgb(255, 5, 255);
            int sizeT = 14;
            TextNodeFontSize = sizeT;
            Font font = new Font("Century Gothic", sizeT, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            this.FontText = font;
            this.Shape = "RoundedRectangle";
            this.Location = location;
            this.TextNodeColor = forecolor;
            this.MainColor = NodeBackColor;
            this.FontText = font;
            this.TextNode = "Text Node";
            this.MainTextBox.ForeColor = TextNodeColor;
            PaintShape(this.Shape);
            CanMove = false;
            CanChangeSize = false;
            FramesMouseDown = false;
            NodeSelected = false;
            this.BorderStyle = DashStyle.Solid;
            this.BorderThickness = 3;
            this.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.Controls.Add(Main);
            Main.Location = new Point(5, 5);
            Main.BackColor = Color.FromArgb(50, 15, 47);
            Main.Controls.Add(MainTextBox);
            Node_information[1] = Shape;
            Node_information[2] = this.Location.X.ToString();
            Node_information[3] = this.Location.Y.ToString();
            Node_information[4] = this.Width.ToString();
            Node_information[5] = this.Height.ToString();
            Node_information[6] = MainColor.R.ToString();
            Node_information[7] = MainColor.G.ToString();
            Node_information[8] = MainColor.B.ToString();
            Node_information[9] = TextNodeColor.R.ToString();
            Node_information[10] = TextNodeColor.G.ToString();
            Node_information[11] = TextNodeColor.B.ToString();
            Node_information[12] = TextNodeFontSize.ToString();
            Node_information[13] = TextNodeFontName;
            Node_information[14] = MainTextBox.Text;
            SetMaxMin();
            MainTextBox.Text = TextNode;
            MainTextBox.Font = FontText;
            MainTextBox.Width = Main.Width;
            MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MainTextBox.Cursor = Cursors.Arrow;
            MainTextBox.TextAlign = HorizontalAlignment.Center;
            Sizetext = TextRenderer.MeasureText(MainTextBox.Text, FontText);
            MainTextBox.Location = new Point(0, (Main.Height - Sizetext.Height) / 2);
            MainTextBox.ForeColor = TextNodeColor;
            MainTextBox.BackColor = Main.BackColor;
            Main.MouseClick += Main_MouseClick;
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
            this.MouseLeave += CustomMapNode_MouseLeave;
            Main.MouseLeave += CustomMapNode_MouseLeave;
            MainTextBox.MouseLeave += CustomMapNode_MouseLeave;
            Main.BackColorChanged += Main_BackColorChanged;
            MainTextBox.ForeColorChanged += MainTextBox_ForeColorChanged;
            MainTextBox.FontChanged += MainTextBox_FontChanged;
        }
        public CustomMapNode(string Text, int X, int Y)
        {
            Point location = new Point(X, Y);
            Size size = new Size(50, 100);
            Color NodeBackColor = Color.FromArgb(50,15,47);
            Color forecolor = Color.FromArgb(255,5,255);
            int sizeT = 14;
            Font font = new Font("Century Gothic", sizeT, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            TextNodeFontSize = sizeT;
            this.FontText = font;
            this.Shape = "RoundedRectangle";
            this.Location = location;
            this.TextNodeColor = forecolor;
            this.MainColor = NodeBackColor;
            this.FontText = font;
            this.TextNode = Text;
            this.MainTextBox.ForeColor = TextNodeColor;
            PaintShape(this.Shape);
            CanMove = false;
            CanChangeSize = false;
            FramesMouseDown = false;
            NodeSelected = false;
            this.BorderStyle = DashStyle.Dot;
            this.BorderThickness = 3;
            this.BorderColor = Color.Yellow;
            this.BackColor = Color.Transparent;
            this.Controls.Add(Main);
            Main.Location = new Point(5, 5);
            Main.BackColor = Color.FromArgb(50, 15, 47); 
            Main.Controls.Add(MainTextBox);
            Node_information[1] = Shape;
            Node_information[2] = this.Location.X.ToString();
            Node_information[3] = this.Location.Y.ToString();
            Node_information[4] = this.Width.ToString();
            Node_information[5] = this.Height.ToString();
            Node_information[6] = MainColor.R.ToString();
            Node_information[7] = MainColor.G.ToString();
            Node_information[8] = MainColor.B.ToString();
            Node_information[9] = TextNodeColor.R.ToString();
            Node_information[10] = TextNodeColor.G.ToString();
            Node_information[11] = TextNodeColor.B.ToString();
            Node_information[12] = TextNodeFontSize.ToString();
            Node_information[13] = TextNodeFontName;
            Node_information[14] = MainTextBox.Text;
            SetMaxMin();
            MainTextBox.ForeColor = TextNodeColor;
            MainTextBox.Text = TextNode;
            MainTextBox.Font = FontText;
            MainTextBox.Width = Main.Width;
            MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MainTextBox.Cursor = Cursors.Arrow;
            MainTextBox.TextAlign = HorizontalAlignment.Center;
            Sizetext = TextRenderer.MeasureText(MainTextBox.Text, FontText);
            MainTextBox.Location = new Point(0, (Main.Height - Sizetext.Height) / 2);
            MainTextBox.BackColor = Main.BackColor;
            Main.MouseClick += Main_MouseClick;
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
            this.MouseLeave += CustomMapNode_MouseLeave;
            Main.MouseLeave += CustomMapNode_MouseLeave;
            MainTextBox.MouseLeave += CustomMapNode_MouseLeave;
            Main.BackColorChanged += Main_BackColorChanged;
            MainTextBox.ForeColorChanged += MainTextBox_ForeColorChanged;
            MainTextBox.FontChanged += MainTextBox_FontChanged;
        }
        public CustomMapNode(string s)
        {
            string[] information = new string[15];
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '_')
                    information[j] += s[i];
                else
                    j++;
            }

            Point location = new Point(Convert.ToInt32(information[2]), Convert.ToInt32(information[3]));
            Size size = new Size(Convert.ToInt32(information[4]), Convert.ToInt32(information[5]));
            Color NodeBackColor = Color.FromArgb(Convert.ToInt32(information[6]), Convert.ToInt32(information[7]), Convert.ToInt32(information[8]));
            Color forecolor = Color.FromArgb(Convert.ToInt32(information[9]), Convert.ToInt32(information[10]), Convert.ToInt32(information[11]));
            int sizeT = Convert.ToInt32(information[12]);
            TextNodeFontSize = sizeT;
            Font font = new Font(information[13], sizeT, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            this.FontText = font;
            this.Shape = information[1];
            this.Location = location;
            this.TextNodeColor = forecolor;
            this.MainColor = NodeBackColor;
            this.FontText = font;
            this.TextNode = information[14];
            this.MainTextBox.ForeColor = TextNodeColor;
            PaintShape(this.Shape);
            CanMove = false;
            CanChangeSize = false;
            FramesMouseDown = false;
            NodeSelected = false;
            this.BorderStyle = DashStyle.Solid; 
            this.BorderThickness = 3;
            this.BorderColor = Color.FromArgb(255,193,7);
            this.BackColor = Color.Transparent;
            this.Controls.Add(Main);
            Main.Location = new Point(5, 5);
            Main.BackColor = MainColor;
            Main.Controls.Add(MainTextBox);
            Node_information[1] = Shape;
            Node_information[2] = this.Location.X.ToString();
            Node_information[3] = this.Location.Y.ToString();
            Node_information[4] = this.Width.ToString();
            Node_information[5] = this.Height.ToString();
            Node_information[6] = MainColor.R.ToString();
            Node_information[7] = MainColor.G.ToString();
            Node_information[8] = MainColor.B.ToString();
            Node_information[9] = TextNodeColor.R.ToString();
            Node_information[10] = TextNodeColor.G.ToString();
            Node_information[11] = TextNodeColor.B.ToString();
            Node_information[12] = TextNodeFontSize.ToString();
            Node_information[13] = TextNodeFontName;
            Node_information[14] = MainTextBox.Text;
            MainTextBox.ForeColor = TextNodeColor;
            MainTextBox.Text = TextNode;
            MainTextBox.Font = FontText;
            MainTextBox.Width = Main.Width;
            MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MainTextBox.Cursor = Cursors.Arrow;
            MainTextBox.TextAlign = HorizontalAlignment.Center;
            Sizetext = TextRenderer.MeasureText(MainTextBox.Text, FontText);
            MainTextBox.Location = new Point(0, (Main.Height - Sizetext.Height) / 2);
            MainTextBox.BackColor = Main.BackColor;
            Main.MouseClick += Main_MouseClick;
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
            this.MouseLeave += CustomMapNode_MouseLeave;
            Main.MouseLeave += CustomMapNode_MouseLeave;
            MainTextBox.MouseLeave += CustomMapNode_MouseLeave;
            Main.BackColorChanged += Main_BackColorChanged;
            MainTextBox.ForeColorChanged += MainTextBox_ForeColorChanged;
            MainTextBox.FontChanged += MainTextBox_FontChanged;
        }

        public void SetFont()
        {
            Font textfont = new Font(TextNodeFontName, TextNodeFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            MainTextBox.Font = textfont;
        }
        public void SetTextColor()
        {
            MainTextBox.ForeColor = TextNodeColor;
        }
        public void SetBackColor()
        {
            Main.BackColor = NodeBackColor;
            MainTextBox.BackColor = NodeBackColor;
        }
        public void SetSizeforShape()
        {
            if (Shape == "Circle" || Shape == "Diamond" || Shape == "Hexagon" || Shape == "RoundedSquare" || Shape == "Square")
            {
                this.MinimumSize = new Size(100, 100);
                this.MaximumSize = new Size(300, 300);
                if (this.Width < this.Height)
                {
                    this.Width = this.Height;
                }
                else
                {
                    this.Height = this.Width;
                }
                Main.Size = new Size(this.Width - 10, this.Height - 10);
                MainTextBox.Width = this.Width - 30;
                MainTextBox.Location = new Point(15, Main.Height / 2 - MainTextBox.Height / 2);
                MainTextBox.ReadOnly = true;

            }
            else if (Shape == "RoundedRectangle" || Shape == "Rectangle" || Shape == "Ellipse" || Shape == "Parallelogram")
            {
                this.MinimumSize = new Size(100, 50);
                this.MaximumSize = new Size(400, 200);
                Main.Size = new Size(this.Width - 10, this.Height - 10);
                MainTextBox.Width = this.Width - 30;
                MainTextBox.Location = new Point(15, Main.Height / 2 - MainTextBox.Height / 2);
                MainTextBox.ReadOnly = true;
            }
        }
        public void SetMaxMin()
        {
            if (Shape == "Circle" || Shape == "Diamond" || Shape == "Hexagon" || Shape == "RoundedSquare" || Shape == "Square")
            {
                this.MinimumSize = new Size(100, 100);
                this.MaximumSize = new Size(300, 300);
                this.Size = MinimumSize;
                Main.Size = new Size(this.Width - 10, this.Height - 10);
                MainTextBox.Width = this.Width - 30;
                MainTextBox.Location = new Point(15, Main.Height / 2 - MainTextBox.Height / 2);
                MainTextBox.ReadOnly = true;

            }
            else if (Shape == "RoundedRectangle" || Shape == "Rectangle" || Shape == "Ellipse" || Shape == "Parallelogram")
            {
                this.MinimumSize = new Size(100, 50);
                this.MaximumSize = new Size(400, 200);
                this.Size = MinimumSize;
                Main.Size = new Size(this.Width - 10, this.Height - 10);
                MainTextBox.Width = this.Width - 30;
                MainTextBox.Location = new Point(15, Main.Height / 2 - MainTextBox.Height / 2);
                MainTextBox.ReadOnly = true;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            if (NodeSelected == false)
            {
                this.BorderColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        public void Main_MouseClick(object sender, MouseEventArgs e)
        {        
            foreach (CustomMapNode customMapNode in MapUI_Form.customMapNodes)
            {
                customMapNode.NodeSelected = false;
                this.BorderStyle = DashStyle.Solid;
                if (this.ID == customMapNode.ID)
                {
                    customMapNode.NodeSelected = true;
                    MapUI_Form.mySelectedMapNode = customMapNode;
                }
            }
            foreach (TreeNode treeNode in TreeUI_Form.treeNodes)
            {
                if (this.ID == treeNode.Name)
                {
                    TreeUI_Form.mySelectedNode = treeNode;
                    break;
                }
            }
            this.BorderColor = Color.CadetBlue;
        }

        private void MainTextBox_FontChanged(object sender, EventArgs e)
        {
            Node_information[12] = MainTextBox.Font.Size.ToString();
            Node_information[13] = MainTextBox.Font.FontFamily.ToString();
        }

        private void MainTextBox_ForeColorChanged(object sender, EventArgs e)
        {

            Node_information[9] = MainTextBox.ForeColor.R.ToString();
            Node_information[10] = MainTextBox.ForeColor.G.ToString();
            Node_information[11] = MainTextBox.ForeColor.B.ToString();
        }

        private void Main_BackColorChanged(object sender, EventArgs e)
        {
            Node_information[6] = Main.BackColor.R.ToString();
            Node_information[7] = Main.BackColor.G.ToString();
            Node_information[8] = Main.BackColor.B.ToString();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Node_information[4] = this.Width.ToString();
            Node_information[5] = this.Height.ToString();
        }
        protected override void OnLocationChanged(EventArgs e)
        {
            Node_information[2] = this.Location.X.ToString();
            Node_information[3] = this.Location.Y.ToString();
        }
        public void ChangeShape(string shape)
        {
            SetSizeforShape();
            GraphicsPath draw = new GraphicsPath();
            switch (shape)
            {
                case "Circle":

                    draw.AddEllipse(0, 0, Main.Width, Main.Width);
                    break;
                case "Diamond":

                    draw.AddPolygon(new Point[]{
                                new Point(0,Main.Height/2),
                                new Point(Main.Width/2,0),
                                new Point(Main.Width,Main.Height/2),
                                new Point(Main.Width/2,Main.Height)
                                                  });
                    break;
                case "Ellipse":

                    draw.AddEllipse(0, 0, Main.Width, Main.Height);
                    break;
                case "Hexagon":

                    draw.AddPolygon(new Point[]{
                                  new Point(Main.Width /2 , 0),
                                  new Point(Main.Width ,Main.Height/4),
                                  new Point(Main.Width,Main.Height/4*3),
                                  new Point(Main.Width/2, Main.Height),
                                  new Point(0, (Main.Height/4*3)),
                                  new Point(0, Main.Height/4)
                                 });
                    break;

                case "RoundedRectangle":

                    draw.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
                    draw.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
                    draw.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
                    draw.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
                    draw.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
                    draw.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
                    draw.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
                    draw.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);
                    break;

                case "RoundedSquare":
                    draw.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
                    draw.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
                    draw.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
                    draw.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
                    draw.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
                    draw.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
                    draw.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
                    draw.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);
                    break;

                case "Square":
                    draw.AddPolygon(new Point[]{
                                new Point(0, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;

                    break;
                case "Rectangle":

                    draw.AddPolygon(new Point[]{
                                new Point(0, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;
                    break;
                case "Parallelogram":
                    draw.AddPolygon(new Point[]{
                                new Point(Main.Width/5, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width/5*4,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;

                    break;

            }
            Main.Region = new Region(draw);

        }
        public void PaintShape(string shape)
        {
            SetMaxMin();
            GraphicsPath draw = new GraphicsPath();
            switch (shape)
            {
                case "Circle":

                    draw.AddEllipse(0, 0, Main.Width, Main.Width);
                    break;
                case "Diamond":

                    draw.AddPolygon(new Point[]{
                                new Point(0,Main.Height/2),
                                new Point(Main.Width/2,0),
                                new Point(Main.Width,Main.Height/2),
                                new Point(Main.Width/2,Main.Height)
                                                  });
                    break;
                case "Ellipse":

                    draw.AddEllipse(0, 0, Main.Width, Main.Height);
                    break;
                case "Hexagon":

                    draw.AddPolygon(new Point[]{
                                  new Point(Main.Width /2 , 0),
                                  new Point(Main.Width ,Main.Height/4),
                                  new Point(Main.Width,Main.Height/4*3),
                                  new Point(Main.Width/2, Main.Height),
                                  new Point(0, (Main.Height/4*3)),
                                  new Point(0, Main.Height/4)
                                 });
                    break;

                case "RoundedRectangle":

                    draw.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
                    draw.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
                    draw.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
                    draw.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
                    draw.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
                    draw.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
                    draw.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
                    draw.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);
                    break;

                case "RoundedSquare":
                    draw.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
                    draw.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
                    draw.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
                    draw.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
                    draw.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
                    draw.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
                    draw.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
                    draw.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);
                    break;

                case "Square":
                    draw.AddPolygon(new Point[]{
                                new Point(0, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;

                    break;
                case "Rectangle":

                    draw.AddPolygon(new Point[]{
                                new Point(0, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;
                    break;
                case "Parallelogram":
                    draw.AddPolygon(new Point[]{
                                new Point(Main.Width/5, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width/5*4,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;

                    break;

            }
            Main.Region = new Region(draw);
        }
        private void CustomMapNode_MouseLeave(object sender, EventArgs e)
        {

            if (NodeSelected == false)
            {
                this.BorderColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
        public void SetNodeSize()
        {
            if (Size.Width == Size.Height)
            {
                Sizetext = TextRenderer.MeasureText(MainTextBox.Text, MainTextBox.Font);
                if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = Main.Width + 10;
                    this.Height = this.Width;
                    Main.Height = Main.Width;

                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    this.Size = MaximumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Height - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                    if (Sizetext.Width < this.Width - 30 && Sizetext.Width > this.MinimumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = MainTextBox.Width + 30;
                    this.Height = this.Width;
                    Main.Height = Main.Width;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                   if (Sizetext.Width < this.MinimumSize.Width - 30)
                {
                    this.Size = this.MinimumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Width - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);
                    MainTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            else
            {
                Sizetext = TextRenderer.MeasureText(MainTextBox.Text, MainTextBox.Font);
                if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = Main.Width + 10;
                    Main.Height = Main.Width / 2;
                    this.Height = Main.Height + 10;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    this.Size = MaximumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Height - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                    if (Sizetext.Width < this.Width - 30 && Sizetext.Width > this.MinimumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = MainTextBox.Width + 30;
                    Main.Height = Main.Width / 2;
                    this.Height = Main.Height + 10;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                   if (Sizetext.Width < this.MinimumSize.Width - 30)
                {
                    this.Size = this.MinimumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Width - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);
                    MainTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            Node_information[16] = MainTextBox.Text;
            if (Size.Width == Size.Height)
            {
                Sizetext = TextRenderer.MeasureText(MainTextBox.Text, MainTextBox.Font);
                if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = Main.Width + 10;
                    this.Height = this.Width;
                    Main.Height = Main.Width;

                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    this.Size = MaximumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Height - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                    if (Sizetext.Width < this.Width - 30 && Sizetext.Width > this.MinimumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = MainTextBox.Width + 30;
                    this.Height = this.Width;
                    Main.Height = Main.Width;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                   if (Sizetext.Width < this.MinimumSize.Width - 30)
                {
                    this.Size = this.MinimumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Width - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);
                    MainTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            else
            {
                Sizetext = TextRenderer.MeasureText(MainTextBox.Text, MainTextBox.Font);
                if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = Main.Width + 10;
                  
                    this.Height = Main.Height + 10;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else if (Sizetext.Width > this.Width - 30 && Sizetext.Width < this.MaximumSize.Width - 30)
                {
                    this.Size = MaximumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Height - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                    if (Sizetext.Width < this.Width - 30 && Sizetext.Width > this.MinimumSize.Width - 30)
                {
                    MainTextBox.Width = Sizetext.Width;
                    Main.Width = MainTextBox.Width + 20;
                    this.Width = MainTextBox.Width + 30;
                 
                    this.Height = Main.Height + 10;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);

                }
                else
                   if (Sizetext.Width < this.MinimumSize.Width - 30)
                {
                    this.Size = this.MinimumSize;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = Main.Width - 20;
                    MainTextBox.Location = new Point(10, Main.Height / 2 - MainTextBox.Height / 2);
                    MainTextBox.TextAlign = HorizontalAlignment.Center;

                }

            }


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath draw = new GraphicsPath();
            switch (shape)
            {
                case "Circle":

                    draw.AddEllipse(0, 0, Main.Width, Main.Width);
                    break;
                case "Diamond":

                    draw.AddPolygon(new Point[]{
                                new Point(0,Main.Height/2),
                                new Point(Main.Width/2,0),
                                new Point(Main.Width,Main.Height/2),
                                new Point(Main.Width/2,Main.Height)
                                                  });
                    break;
                case "Ellipse":

                    draw.AddEllipse(0, 0, Main.Width, Main.Height);
                    break;
                case "Hexagon":

                    draw.AddPolygon(new Point[]{
                                  new Point(Main.Width /2 , 0),
                                  new Point(Main.Width ,Main.Height/4),
                                  new Point(Main.Width,Main.Height/4*3),
                                  new Point(Main.Width/2, Main.Height),
                                  new Point(0, (Main.Height/4*3)),
                                  new Point(0, Main.Height/4)
                                 });
                    break;

                case "RoundedRectangle":

                    draw.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
                    draw.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
                    draw.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
                    draw.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
                    draw.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
                    draw.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
                    draw.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
                    draw.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);
                    break;

                case "RoundedSquare":
                    draw.AddArc(0, 0, Main.Width / 4, Main.Width / 4, 180, 90);
                    draw.AddLine(Main.Width / 8, 0, Main.Width - Main.Width / 8, 0);
                    draw.AddArc(Main.Width - Main.Width / 4, 0, Main.Width / 4, Main.Width / 4, 270, 90);
                    draw.AddLine(Main.Width, Main.Width / 8, Main.Width, Main.Height - Main.Width / 8);
                    draw.AddArc(Main.Width - Main.Width / 4, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 0, 90);
                    draw.AddLine(Main.Width - Main.Width / 8, Main.Height, Main.Width / 8, Main.Height);
                    draw.AddArc(0, Main.Height - Main.Width / 4, Main.Width / 4, Main.Width / 4, 90, 90);
                    draw.AddLine(0, Main.Height - Main.Width / 8, 0, Main.Width / 8);
                    break;

                case "Square":
                    draw.AddPolygon(new Point[]{
                                new Point(0, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;

                    break;
                case "Rectangle":

                    draw.AddPolygon(new Point[]{
                                new Point(0, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;
                    break;
                case "Parallelogram":
                    draw.AddPolygon(new Point[]{
                                new Point(Main.Width/5, 0),
                                new Point(Main.Width,0),
                                new Point(Main.Width/5*4,Main.Height),
                                new Point(0,Main.Height)
                                                  }); ;

                    break;

            }
            Main.Region = new Region(draw);
        }
        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainTextBox.ReadOnly = false;
            MainTextBox.KeyDown += MainTextBox_KeyDown;
        }

        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainTextBox.ReadOnly = true;
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
            CanMove = false;
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

                if (this.Location.Y + this.Height / 2 > line1.Location.Y)
                {
                    line2.Height = line2.Height + (e.Y - Main_Y);
                    line3.Location = new Point(line1.Location.X + line1.Width, line2.Location.Y + line2.Height);
                    line3.Width = line3.Width + (e.X - Main_X);
                }
                else
                    if (this.Location.Y + this.Height / 2 <= line1.Location.Y)
                {
                    line3.Location = new Point(line1.Location.X + line1.Width, this.Location.Y + this.Height / 2);
                    line3.Width = line3.Width + (e.X - Main_X);
                    line2.Location = new Point(line2.Location.X, line3.Location.Y);
                    line2.Height = line1.Location.Y - line3.Location.Y;
                }
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            CanMove = true;
            Main_X = e.X;
            Main_Y = e.Y;
            foreach (CustomMapNode customMapNode in MapUI_Form.customMapNodes)
            {
                customMapNode.NodeSelected = false;
                this.BorderStyle = DashStyle.Solid;
                if (this.ID == customMapNode.ID)
                {
                    customMapNode.NodeSelected = true;
                    MapUI_Form.mySelectedMapNode = customMapNode;
                }
            }
            foreach (TreeNode treeNode in TreeUI_Form.treeNodes)
            {
                if (this.ID == treeNode.Name)
                {
                    TreeUI_Form.mySelectedNode = treeNode;
                    break;
                }
            }
            this.BorderThickness = 3;
            this.BorderColor = Color.Blue;
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
            {
                if (this.Width == this.Height)
                {
                    this.Width = (Frames_X);
                    Main.Width = this.Width - 10;
                    MainTextBox.Width = this.Width - 30;
                    MainTextBox.TextAlign = HorizontalAlignment.Center;
                    this.Height = this.Width;
                    Main.Height = this.Height - 10;
                    MainTextBox.Location = new Point(15, Main.Height / 2 - MainTextBox.Height / 2);
                }
                else
                {
                    this.Width = (Frames_X);
                    Main.Width = this.Width - 10;
                    MainTextBox.Width = this.Width - 30;
                    MainTextBox.TextAlign = HorizontalAlignment.Center;
                    //this.Height = this.Width / 2;
                    //Main.Height = this.Height - 10;
                    MainTextBox.Location = new Point(15, Main.Height / 2 - MainTextBox.Height / 2);
                }
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (CanChangeSize && NodeSelected)
            {
                FramesMouseDown = true;
                CanMove = false;
            }
            foreach (CustomMapNode customMapNode in MapUI_Form.customMapNodes)
            {
                customMapNode.NodeSelected = false;
                this.BorderStyle = DashStyle.Solid;
                if (this.ID == customMapNode.ID)
                {
                    customMapNode.NodeSelected = true;
                    MapUI_Form.mySelectedMapNode = customMapNode;
                }
            }
            foreach (TreeNode treeNode in TreeUI_Form.treeNodes)
            {
                if (this.ID == treeNode.Name)
                {
                    TreeUI_Form.mySelectedNode = treeNode;
                    break;
                }
            }
            this.BorderThickness = 3;
            this.BorderColor = Color.CadetBlue;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (FramesMouseDown && CanMove == false)
            {
                if (MinimumSize.Width == MinimumSize.Height)
                {
                    FramesMouseDown = false;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = this.Width - 30;
                    MainTextBox.TextAlign = HorizontalAlignment.Center;
                }
                else
                {
                    FramesMouseDown = false;
                    Main.Width = this.Width - 10;
                    Main.Height = this.Height - 10;
                    MainTextBox.Width = this.Width - 30;
                    MainTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            foreach (CustomMapNode customMapNode in MapUI_Form.customMapNodes)
            {
                customMapNode.NodeSelected = false;
                this.BorderStyle = DashStyle.Solid;
                if (this.ID == customMapNode.ID)
                {
                    customMapNode.NodeSelected = true;
                    MapUI_Form.mySelectedMapNode = customMapNode;
                }
            }
            foreach (TreeNode treeNode in TreeUI_Form.treeNodes)
            {
                if (this.ID == treeNode.Name)
                {
                    TreeUI_Form.mySelectedNode = treeNode;
                    break;
                }
            }
            this.BorderThickness = 3;
            this.BorderColor = Color.CadetBlue;
        }
        public string Creat_Information(string[] Node_information)
        {
            return "_" + Shape + "_" + Location.X.ToString() + "_" + Location.Y.ToString() + "_" 
                + this.Width.ToString() + "_" + this.Height.ToString() + "_" + Main.BackColor.R.ToString()
                + "_" + Main.BackColor.G.ToString() + "_" + Main.BackColor.B.ToString() + "_" 
                + MainTextBox.ForeColor.R.ToString() + "_" + MainTextBox.ForeColor.G.ToString() + "_" 
                + MainTextBox.ForeColor.B.ToString() + "_" + TextNodeFontSize.ToString() + "_" + TextNodeFontName + "_";
        }
        public override string ToString()
        {
            return Creat_Information(Node_information);
        }
        public void Move(int X, int Y)
        {
            List<CustomMapNode> customMapNodes = new List<CustomMapNode>();
            foreach (TreeNode treeNode in TreeUI_Form.treeNodes)
            {
                if (treeNode.Name == this.ID)
                {
                    customMapNodes = DeleteRecursive(treeNode);
                }
            }
            foreach (CustomMapNode customMapNode in customMapNodes)
            {
                customMapNode.Location = new Point(customMapNode.Location.X + X, customMapNode.Location.Y + Y);
            }
        }
        private void DeleteRecursive1(List<CustomMapNode> customMapNodes,TreeNode treeNode)
        {
            CustomMapNode customMapNode = new CustomMapNode();
            foreach(CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
            {
                if(customMapNode1.ID == treeNode.Name)
                {
                    customMapNode = customMapNode1;
                    break;
                }
            }
            customMapNodes.Add(customMapNode);
            foreach (TreeNode tn in treeNode.Nodes)
            {
                DeleteRecursive1(customMapNodes, tn);
            }
        }
        public List<CustomMapNode> DeleteRecursive(TreeNode treeNode)
        {
            List<CustomMapNode> customMapNodes = new List<CustomMapNode>();
            // IN ra từng node sử dụng đệ quy. 
            foreach (TreeNode n in treeNode.Nodes)
            {
                DeleteRecursive1(customMapNodes, n);
            }
            return customMapNodes;
        }
      
        public void line(CustomMapNode node)
        {
            Point P1 = new Point(node.Location.X + node.Width, node.Location.Y + node.Height / 2);
            Point P2 = new Point(P1.X + 20, P1.Y);
            Point P3 = new Point(P2.X, P2.Y + ((this.Location.Y + this.Height / 2) - (node.Location.Y + node.Height / 2)));
            Point P4 = new Point(this.Location.X, this.Location.Y + this.Height / 2);
            line1.Height = 5;
            line2.Width = 5;
            line3.Height = 5;
            line1.BackColor = Color.Red;
            line2.BackColor = Color.Red;
            line3.BackColor = Color.Red;
            line1.Location = P1;
            line1.Width = 20;
            line2.Location = new Point(P2.X, P2.Y);
            line2.Height = P3.Y - P2.Y;
            line3.Location = P3;
            line3.Width = P4.X - P3.X;

        }
    }
}
