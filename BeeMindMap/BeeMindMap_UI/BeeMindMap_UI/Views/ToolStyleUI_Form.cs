using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BeeMindMap_UI.Views
{
    public partial class ToolStyleUI_Form : Form
    {
        public ToolStyleUI_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Shape_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button bt = (System.Windows.Forms.Button)sender;
            if (MapUI_Form.mySelectedMapNode == null)
                return;
            else
            {
                MapUI_Form.mySelectedMapNode.Shape = bt.Name;
                MapUI_Form.mySelectedMapNode.ChangeShape(MapUI_Form.mySelectedMapNode.Shape);
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && MapUI_Form.mySelectedMapNode != null)
            {
                btnBackColor.BackColor = colorDialog1.Color;
                MapUI_Form.mySelectedMapNode.MainColor = btnBackColor.BackColor;
                MapUI_Form.mySelectedMapNode.SetBackColor();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && MapUI_Form.mySelectedMapNode != null)
            {
                button9.BackColor = colorDialog1.Color;
                MapUI_Form.mySelectedMapNode.TextNodeColor = button9.BackColor;
                MapUI_Form.mySelectedMapNode.SetTextColor();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label7.Text = fontDialog1.Font.FontFamily.Name;
                label8.Text = fontDialog1.Font.Style.ToString();
                label9.Text = Convert.ToInt32(fontDialog1.Font.Size).ToString();

                if (MapUI_Form.mySelectedMapNode != null)
                {
                    MapUI_Form.mySelectedMapNode.MainTextBox.Font = fontDialog1.Font;
                    MapUI_Form.mySelectedMapNode.SetNodeSize();
                }
            }
        }
    }
}