using BeeMindMap_UI.Controllers;
using BeeMindMap_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeMindMap_UI.Views
{
    public partial class WelcomeUI_Form : Form
    {
        public System.Windows.Forms.Timer timer;
        public WelcomeUI_Form()
        {
            InitializeComponent();
            ResizePiturebox(pictureBox1);
            HideRegister();
            using (var _context = new Context())
            {
                _context.Database.CreateIfNotExists();
            }
            LoadRemember();
        }
        private void LoadRemember()
        {
            tbUserName.Text = Properties.Settings.Default.user;
            tbPassword.Text = Properties.Settings.Default.password;
            radioButton1.Checked = Properties.Settings.Default.Remember;
            if (radioButton1.Checked)
            {
                PassVisible.Visible = false;
            }
            else
            {
                PassVisible.Visible = true;
            }
        }
        private void HideRegister()
        {
            KeyVisible.Visible = false;
            keyinvisible.Visible = false;
            pbconfirm.Visible = tbConfirm.Visible = panel3.Visible = false;
            pbPhone.Visible = tbPhone.Visible = panel4.Visible = false;
            btLogin.Visible = label1.Visible = true;
            radioButton1.Visible = true;
            btRegister.Text = "Register";
        }
        private bool ResizePiturebox(PictureBox pictureBox)
        {
            //Chỉnh Khung của picturebox về Tròn
            //Trả về False nếu thất bại
            try
            {
                Rectangle r = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                Region rg = new Region(gp);
                pictureBox.Region = rg;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void resetColor()
        {
            tbUserName.ForeColor = Color.White;
            tbPassword.ForeColor = Color.White;
            pbUserName.BackgroundImage = Properties.Resources.user_50px;
            pbPassword.BackgroundImage = Properties.Resources.unlock_50px;
            panel1.BackColor = panel2.BackColor = panel3.BackColor = panel4.BackColor = Color.White;
            tbConfirm.ForeColor = tbPhone.ForeColor = Color.White;
            pbconfirm.BackgroundImage = Properties.Resources.key_2_50px;
            pbPhone.BackgroundImage = Properties.Resources.phone_50px;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            User user = new User();
            user.UserName = tbUserName.Text.Trim();
            user.PassWord = tbPassword.Text.Trim();
            User local = UserControllers.Find(user.UserName);
            if (local == null)
            {
                MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                messageBox.richTextBox1.Text = "Bạn Sai Tài Khoảng Hoặc Mật Khẩu";
                messageBox.bt1.Visible = messageBox.bt2.Visible = false;
                messageBox.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            else
            {
                if (local.CheckPass(user.PassWord))
                {
                    this.Cursor = Cursors.Default;
                    Properties.Settings.Default.Remember = radioButton1.Checked;
                    if (radioButton1.Checked)
                    {
                        Properties.Settings.Default.user = user.UserName;
                        Properties.Settings.Default.password = user.PassWord;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {

                        Properties.Settings.Default.user = "";
                        Properties.Settings.Default.password = "";
                        Properties.Settings.Default.Save();
                    }
                    Now._user = user;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                    messageBox.richTextBox1.Text = "Bạn Sai Tài Khoảng Hoặc Mật Khẩu";
                    messageBox.bt1.Visible = messageBox.bt2.Visible = false;
                    messageBox.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            btLogin.Location = new Point(btLogin.Location.X, btLogin.Location.Y + 20);
            if(btLogin.Location.X == 977 && btLogin.Location.Y == 602)
            {
                timer.Stop();
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btMinsize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void tbUserName_Click(object sender, EventArgs e)
        {
            resetColor();
            tbUserName.ForeColor = Color.FromArgb(255, 193, 7);
            pbUserName.BackgroundImage = Properties.Resources.user_c_2_50px;
            panel1.BackColor = Color.FromArgb(255, 193, 7);
        }
        private void tbPhone_Click(object sender, EventArgs e)
        {
            resetColor();
            tbPhone.ForeColor = Color.FromArgb(255, 193, 7);
            pbPhone.BackgroundImage = Properties.Resources.phone_c_50px;
            panel4.BackColor = Color.FromArgb(255, 193, 7);
        }
        private void tbConfirm_Click(object sender, EventArgs e)
        {
            resetColor();
            tbConfirm.ForeColor = Color.FromArgb(255, 193, 7);
            pbconfirm.BackgroundImage = Properties.Resources.key_c_50px;
            panel3.BackColor = Color.FromArgb(255, 193, 7);
        }
        private void tbPassword_Click(object sender, EventArgs e)
        {
            resetColor();
            tbPassword.ForeColor = Color.FromArgb(255, 193, 7);
            pbPassword.BackgroundImage = Properties.Resources.unlock_c_50px;
            panel2.BackColor = Color.FromArgb(255, 193, 7);
            if (PassVisible.Visible == false && Passinvisible.Visible == false)
            {
                tbPassword.Text = "";
                PassVisible.Visible = true;
            }
        }
        private void pbFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com/trungtin27/");
        }
        private void pbGoogle_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com/");
        }
        private void pbInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("http://www./");
        }
        private void btExit_MouseHover(object sender, MouseEventArgs e)
        {
            btExit.ForeColor = Color.FromArgb(255, 193, 7);
        }
        private void btExit_MouseLeave(object sender, EventArgs e)
        {
            btExit.ForeColor = Color.White;
        }
        private void btMinsize_MouseHover(object sender, MouseEventArgs e)
        {
            btMinsize.ForeColor = Color.FromArgb(255, 193, 7);
        }
        private void btMinsize_MouseLeave(object sender, EventArgs e)
        {
            btMinsize.ForeColor = Color.White;
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            resetColor();
            if (btRegister.Text == "Create")
            {
                this.Cursor = Cursors.WaitCursor;
                User user = new User();
                user.UserName = tbUserName.Text.Trim();
                user.PassWord = tbPassword.Text.Trim();
                user.Phone = tbPhone.Text.Trim();
                if (UserControllers.Add(user))
                {
                    MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                    messageBox.richTextBox1.Text = "Thêm Thành công!";
                    messageBox.bt1.Visible = messageBox.bt2.Visible = false;
                    messageBox.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                    messageBox.richTextBox1.Text = "UserName Đã có!";
                    messageBox.bt1.Visible = messageBox.bt2.Visible = false;
                    messageBox.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                tbUserName.Clear();
                tbPassword.Clear();
                KeyVisible.Visible = true;
                PassVisible.Visible = true;
                radioButton1.Visible = false;
                pbconfirm.Visible = tbConfirm.Visible = panel3.Visible = true;
                pbPhone.Visible = tbPhone.Visible = panel4.Visible = true;
                btLogin.Visible = label1.Visible = false;
                btRegister.Text = "Create";
                btBack.Visible = true;
                this.AcceptButton = btRegister;
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            HideRegister();
            resetColor();
            tbConfirm.Clear();
            tbPhone.Clear();
            btBack.Visible = false;
        }
        private void btBack_MouseHover(object sender, MouseEventArgs e)
        {
            btBack.BackgroundImage = Properties.Resources.back_c_50px;
            btBack.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btBack_MouseLeave(object sender, EventArgs e)
        {
            btBack.BackgroundImage = Properties.Resources.back_50px;
            btBack.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            resetColor();
            radioButton1.Checked = !radioButton1.Checked;
        }
        private void Button_Visible_Leave(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_invisible_30px_2;
        }
        private void Button_Visible_Move(object sender, MouseEventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_invisible_30px_1;
        }
        private void Button_inVisible_Leave(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_eye_30px_1;
        }
        private void Button_inVisible_Move(object sender, MouseEventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_eye_30px;
        }

        private void PassVisible_Click(object sender, EventArgs e)
        {
            if (PassVisible.Visible == true)
            {
                PassVisible.Visible = false;
                Passinvisible.Visible = true;
                tbPassword.PasswordChar = '\0';
            }                   
            else
            {
                PassVisible.Visible = true;
                Passinvisible.Visible = false;
                tbPassword.PasswordChar = '✽';
            }                
        }

        private void KeyVisible_Click(object sender, EventArgs e)
        {
            if (KeyVisible.Visible == true)
            {
                KeyVisible.Visible = false;
                keyinvisible.Visible = true;
                tbConfirm.PasswordChar = '\0';
            }
            else
            {
                KeyVisible.Visible = true;
                keyinvisible.Visible = false;
                tbConfirm.PasswordChar = '✽';
            }
        }

        private void Passinvisible_Click(object sender, EventArgs e)
        {
            if (Passinvisible.Visible == false)
            {
                PassVisible.Visible = false;
                Passinvisible.Visible = true;
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                PassVisible.Visible = true;
                Passinvisible.Visible = false;
                tbPassword.PasswordChar = '✽';
            }
        }

        private void keyinvisible_Click(object sender, EventArgs e)
        {
            if (keyinvisible.Visible == false)
            {
                KeyVisible.Visible = false;
                keyinvisible.Visible = true;
                tbConfirm.PasswordChar = '\0';
            }
            else
            {
                KeyVisible.Visible = true;
                keyinvisible.Visible = false;
                tbConfirm.PasswordChar = '✽';
            }
        }
    }
}
