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
    public partial class ViewUI : EditUI
    {
        [Browsable(true)]
        public event EventHandler<EventArgs> SetCheckMap_Tree;
        public ViewUI()
        {
            InitializeComponent();
            this.SetCheckMap_Tree += ViewUI_SetCheckMap_Tree;
        }

        private void ViewUI_SetCheckMap_Tree(object sender, EventArgs e)
        {
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            this.SetCheckMap_Tree(sender, e);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox2.Checked;
            this.SetCheckMap_Tree(sender, e);
        }
    }
}
