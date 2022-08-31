using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_management_system.cs
{
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
              Opacity = 0.95;
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
          
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void registerLabel_Click_1(object sender, EventArgs e)
        {
            new SingUp().Show();
            this.Hide();
        }

        private void LoginBtnimg_Click(object sender, EventArgs e)
        {
            new MainWindow().Show();
            this.Hide();
        }

        private void feildClearLabel_Click(object sender, EventArgs e)
        {
            UserIdBox.Clear();
            PassWordBox.Clear();
            UserIdBox.Focus();
            PassWordBox_Leave(sender, e);
        }

        private void UserIdBox_Enter(object sender, EventArgs e)
        {
            if(UserIdBox.Text == "Example@semple.com")
            {
                UserIdBox.Text = "";
                UserIdBox.ForeColor = Color.White;
            }
        }

        private void UserIdBox_Leave(object sender, EventArgs e)
        {
            if(UserIdBox.Text == "")
            {
                UserIdBox.Text = "Example@semple.com";
                UserIdBox.ForeColor = Color.Gray;
            }
        }

        private void PassWordBox_Enter(object sender, EventArgs e)
        {
            if(PassWordBox.Text == "password")
            {
                PassWordBox.Text = "";
                PassWordBox.ForeColor = Color.White;
            }
        }

        private void PassWordBox_Leave(object sender, EventArgs e)
        {
            if (PassWordBox.Text == "")
            {
                PassWordBox.Text = "password";
                PassWordBox.ForeColor = Color.Gray;
            }
        }
    }
}
