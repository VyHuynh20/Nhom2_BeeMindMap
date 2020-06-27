using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeeMindMap_UI.Models;
using BeeMindMap_UI.Views;

namespace BeeMindMap_UI
{    public class Now
    {
        public static User _user;
        public static Map _map;
    }
    public static class Program
    {
        static User _user;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWorkUI_Form mainWorkUI_Form = new MainWorkUI_Form();
            mainWorkUI_Form.DialogResult = DialogResult.Abort;
            WelcomeUI_Form welcomeUI_Form = new WelcomeUI_Form();
            welcomeUI_Form.DialogResult = DialogResult.Abort;
            while (mainWorkUI_Form.DialogResult == DialogResult.Abort && welcomeUI_Form.DialogResult != DialogResult.Cancel)
            {
                welcomeUI_Form = new WelcomeUI_Form();
                welcomeUI_Form.ShowDialog();
                if (welcomeUI_Form.DialogResult == DialogResult.OK)
                {
                    mainWorkUI_Form = new MainWorkUI_Form();
                    mainWorkUI_Form.ShowDialog();                    
                }          
            }
        }
    }
}
