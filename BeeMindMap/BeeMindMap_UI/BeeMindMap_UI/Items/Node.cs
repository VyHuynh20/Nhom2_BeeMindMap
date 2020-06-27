using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeMindMap_UI
{
    public class Node : Panel
    {
        public Button bt;
        public TextBox tb;
        public Node()
        {
            this.bt = new Button();
            bt.Width = this.Width-2;
            bt.Height = this.Height-2;
            bt.Text = "Test";
            bt.UseVisualStyleBackColor = true;
            //bt.DoubleClick += Bt_DoubleClick;
            bt.Click += Bt_DoubleClick;
            bt.MouseDown += Bt_MouseDown;
            bt.KeyDown += Bt_KeyDown;
            this.Controls.Add(bt);

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] points = { new Point(40, 40), new Point(80, 40), new Point(40, 60), new Point(80, 80) };
            gp.AddPolygon(points);
            //Region rg = new Region(gp);
            //this.Region = rg;
        }

        private void Bt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bt.Text = "Fulltest";
            }
        }

        private void Bt_KeyDown(object sender, KeyEventArgs e)
        {
            if (bt.CanSelect == true)
            {
                bt.Text = "Fulltest";
            }
        }

        protected void Bt_DoubleClick(object sender, EventArgs e)
        {
            bt.Select();            
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            bt.Text = "FullTest";
        }
    }
}
