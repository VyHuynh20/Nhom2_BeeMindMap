using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BeeMindMap_UI.Views
{
    public partial class EditUI : UserControl
    {
        [Category("Data"), Description("Button")]
        public string Button1
        {
            get { return this.button1.Text; }
            set { this.button1.Text = value; }
        }
        public string Button2
        {
            get { return this.button2.Text; }
            set { this.button2.Text = value; }
        }
        public string Button3
        {
            get { return this.button3.Text; }
            set { this.button3.Text = value; }
        }
        public string Button4
        {
            get { return this.button4.Text; }
            set { this.button4.Text = value; }
        }
        [Browsable(true)]
        public event EventHandler<EventArgs> SetButton1Clicked;
        public event EventHandler<EventArgs> SetButton2Clicked;
        public event EventHandler<EventArgs> SetButton3Clicked;
        public event EventHandler<EventArgs> SetButton4Clicked;

        public EditUI()
        {
            InitializeComponent();
            this.Visible = false;
            this.SetButton1Clicked += EditUI_SetButton1Clicked;
            this.SetButton2Clicked += EditUI_SetButton2Clicked;
            this.SetButton3Clicked += EditUI_SetButton3Clicked;
            this.SetButton4Clicked += EditUI_SetButton4Clicked;
        }
        protected void EditUI_SetButton2Clicked(object sender, EventArgs e)
        {
        }
        #region tạo event
        protected void EditUI_SetButton4Clicked(object sender, EventArgs e)
        {
        }

        protected void EditUI_SetButton3Clicked(object sender, EventArgs e)
        {
        }
        protected void EditUI_SetButton1Clicked(object sender, EventArgs e)
        {
        }
        protected void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SetButton1Clicked(sender, e);
        }

        protected void EditUI_Load(object sender, EventArgs e)
        {

        }

        protected void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SetButton2Clicked(sender, e);
        }
        #endregion

        protected void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SetButton3Clicked(sender, e);
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SetButton4Clicked(sender, e);
        }

        protected void EditUI_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
