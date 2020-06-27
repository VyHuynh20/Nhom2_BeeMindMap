using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeMindMap_UI.Views
{
    public partial class FileUI : EditUI
    {
        public Timer time;
        [Category("Data"), Description("Button")]
        public string Button5
        {
            get { return this.button5.Text; }
            set { this.button5.Text = value; }
        }
        [Browsable(true)]
        public event EventHandler<EventArgs> SetButton5Clicked;
        public FileUI()
        {
            InitializeComponent();
            time = new Timer();
            time.Interval = 1;
            this.SetButton5Clicked += FileUI_SetButton5Clicked;
        }

        private void FileUI_SetButton5Clicked(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.SetButton5Clicked(sender, e);
        }
    }
}
