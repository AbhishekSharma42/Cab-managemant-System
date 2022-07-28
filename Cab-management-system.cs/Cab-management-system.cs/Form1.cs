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

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Blue;
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Black;
        }

        private void feildClearLabel_MouseEnter(object sender, EventArgs e)
        {
            feildClearLabel.ForeColor = Color.Red;
        }

        private void feildClearLabel_MouseLeave(object sender, EventArgs e)
        {
            feildClearLabel.ForeColor = Color.Black;
        }

        private void forgetPassLable_MouseEnter(object sender, EventArgs e)
        {
            forgetPassLable.ForeColor = Color.Blue;
        }

        private void forgetPassLable_MouseLeave(object sender, EventArgs e)
        {
            if (DarkModeBtn.CheckState == 0)
            {
                forgetPassLable.ForeColor = Color.Black;
            }
            else {
                forgetPassLable.ForeColor = Color.White;
            }
            
        }
           
        
       
        private void DarkModeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkModeBtn.CheckState == 0)
            {
                mainPnnel.BackColor = Color.White;
                LoginLabel.ForeColor = Color.Black;
                registerLabel.ForeColor = Color.Black;
                feildClearLabel.ForeColor = Color.Black;
                forgetPassLable.ForeColor = Color.Black;
               
                UserIdBox.BackColor = Color.White;
                UserIdBox.ForeColor = Color.Black;
                UserIdLine.BackColor = Color.Black;

                PassWordBox.BackColor = Color.White;
                PassWordBox.ForeColor = Color.Black;
                PasswordLine.BackColor = Color.Black;
            }
            
            else
            {
                mainPnnel.BackColor = Color.FromArgb(2, 6, 40);
                LoginLabel.ForeColor = Color.White;
                registerLabel.ForeColor = Color.White;
                feildClearLabel.ForeColor = Color.White;
                forgetPassLable.ForeColor = Color.White;
                
                UserIdBox.BackColor = Color.FromArgb(2, 6, 40);
                UserIdBox.ForeColor = Color.White;
                UserIdLine.BackColor = Color.Red;

                PassWordBox.BackColor = Color.FromArgb(2, 6, 40);
                PassWordBox.ForeColor = Color.White;
                PasswordLine.BackColor = Color.Red;
            }
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


    }
}
