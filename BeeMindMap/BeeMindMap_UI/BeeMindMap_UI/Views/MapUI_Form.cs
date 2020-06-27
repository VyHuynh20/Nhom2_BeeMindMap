using BeeMindMap_UI.Models;
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
    public partial class MapUI_Form : Form
    {
        public static List<CustomMapNode> customMapNodes;
        public ToolStyleUI_Form toolStyleUI_Form;
        public ToolMapUI_Form toolMapUI_Form;
        public static CustomMapNode mySelectedMapNode;
        public MapUI_Form()
        {
            InitializeComponent();
            CreateToolStyle_Map();
            customMapNodes = new List<CustomMapNode>();
        }

        private void CreateToolStyle_Map()
        {
            toolStyleUI_Form = new ToolStyleUI_Form();
            toolStyleUI_Form.TopLevel = false;
            pnTool_List.Controls.Add(toolStyleUI_Form);
            toolStyleUI_Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            toolStyleUI_Form.Dock = DockStyle.Fill;
            toolStyleUI_Form.Show();
            toolMapUI_Form = new ToolMapUI_Form();
            toolMapUI_Form.TopLevel = false;
            pnTool_List.Controls.Add(toolMapUI_Form);
            toolMapUI_Form.FormBorderStyle = FormBorderStyle.None;
            toolMapUI_Form.Dock = DockStyle.Fill;
            toolMapUI_Form.Hide();
            btMap.BackColor = toolMapUI_Form.BackColor;
            btStyle.BackColor = toolStyleUI_Form.BackColor;
        }

        private void btStyle_Click(object sender, EventArgs e)
        {
            btMap.BackColor = toolMapUI_Form.BackColor;
            btStyle.BackColor = toolStyleUI_Form.BackColor;
            toolMapUI_Form.Hide();
            toolStyleUI_Form.Show();
        }

        private void btMap_Click(object sender, EventArgs e)
        {
            btMap.BackColor = toolMapUI_Form.BackColor;
            btStyle.BackColor = toolStyleUI_Form.BackColor;
            toolMapUI_Form.Show();
            toolStyleUI_Form.Hide();
        }

        private void pnTool_Resize(object sender, EventArgs e)
        {

        }
    }
}
