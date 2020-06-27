using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeMindMap_UI.Views
{
    public partial class MessageBoxUI_Form : Form
    {
        public MessageBoxUI_Form()
        {
            InitializeComponent();
        }

        public MessageBoxUI_Form(ref int flag, string title,string text, string BT1, string BT2, string BT3)
        {
            InitializeComponent();
            lbTitle.Text = title;
            richTextBox1.Text = text;
            if (BT1 is null) bt1.Visible = false;
            else bt1.Text = BT1;
            if (BT2 is null) bt2.Visible = false;
            else bt2.Text = BT2;
            if (BT3 is null) bt3.Visible = false;
            else bt3.Text = BT3;
            Cursor = Cursors.Default;
        }
    }
}
