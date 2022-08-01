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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
            homePage Homepage = new homePage();
            addUserControl(Homepage);
        }
        //######################################################################
        //######################################################################
        //                  title bar Drage and drop
        //######################################################################
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void TitlebarPnnel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        
        //######################################################################
        //  Window Button Action
        //######################################################################
        private void CloseWin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //###################################################################
        //   TitleBar Button Mouse hover efect
        //###################################################################
        private void CloseWin_MouseEnter(object sender, EventArgs e)
        {
            CloseWin.BackColor = Color.Red;
        }

        private void CloseWin_MouseLeave(object sender, EventArgs e)
        {
            CloseWin.BackColor = Color.FromArgb(2, 6, 40);
        }
        
        private void MinimizeBtnImg_MouseEnter(object sender, EventArgs e)
        {
            MinimizeBtnImg.BackColor = Color.Blue;
        }

        private void MinimizeBtnImg_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBtnImg.BackColor = Color.FromArgb(2, 6, 40);
        }

        private void MinimizeBtnImg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
            
        //###################################################################
        //Side bar 
        //###################################################################
        private void SideBarBtnimg_Click(object sender, EventArgs e)
        {
            if (SideBarPannel.Width == SideBarPannel.MaximumSize.Width)
            {
                SideBarPannel.Width = SideBarPannel.MinimumSize.Width;
                UserName.Hide();
                userPannal.Hide();
            }
            else if (SideBarPannel.Width == SideBarPannel.MinimumSize.Width)
            {
                SideBarPannel.Width = SideBarPannel.MaximumSize.Width;
                UserName.Show();
                userPannal.Show();
            }
        }

        //#########################################################################
        //#########################################################################
        //Side bar open Button
        //#########################################################################
        private void SideBarBtnimg_MouseEnter(object sender, EventArgs e)
        {
            SideBarBtnimg.BackColor = Color.LightBlue;
        }

        private void SideBarBtnimg_MouseLeave(object sender, EventArgs e)
        {
            SideBarBtnimg.BackColor = Color.FromArgb(2, 6, 40);
        }

        //#########################################################################
        //   User Page Controle System -addUserControl is a User definde Function
        //#########################################################################
        private void addUserControl(UserControl UserControl) {
            UserControl.Dock = DockStyle.Fill;
            mainControllPannl.Controls.Clear();
            mainControllPannl.Controls.Add(UserControl);
            UserControl.BringToFront();
        }


        //############################################################################
        //############################################################################
        private void HomeBtn_MouseEnter(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.Red;
            HomeBtnlabel.BackColor = Color.Red;
            HomeBtnIcon.BackColor = Color.Red;
        }

        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.Navy;
            HomeBtnlabel.BackColor = Color.Navy;
            HomeBtnIcon.BackColor = Color.Navy;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            homePage Homepage = new homePage();
            addUserControl(Homepage);
        }
        private void HomeBtnlabel_Click(object sender, EventArgs e)
        {
            homePage Homepage = new homePage();
            addUserControl(Homepage);
        }

        private void HomeBtnIcon_Click(object sender, EventArgs e)
        {
            homePage Homepage = new homePage();
            addUserControl(Homepage);
        }
        
        
        //############################################################################
        //############################################################################
        private void CabbookingBtn_MouseEnter(object sender, EventArgs e)
        {
            CabbookingBtn.BackColor = Color.Red;
            cabBookingImg.BackColor = Color.Red;
            CabBookingLabel.BackColor = Color.Red;
        }

        private void CabbookingBtn_MouseLeave(object sender, EventArgs e)
        {
            CabbookingBtn.BackColor = Color.Navy;
            cabBookingImg.BackColor = Color.Navy;
            CabBookingLabel.BackColor = Color.Navy;
        }

        private void CabbookingBtn_Click(object sender, EventArgs e)
        {
            CabBooking cabBooking = new CabBooking();
            addUserControl(cabBooking);
        }
        private void CabBookingLabel_Click(object sender, EventArgs e)
        {
            CabBooking cabBooking = new CabBooking();
            addUserControl(cabBooking);
        }
        private void cabBookingImg_Click(object sender, EventArgs e)
        {
            CabBooking cabBooking = new CabBooking();
            addUserControl(cabBooking);
        }
        //############################################################################
        //############################################################################
        private void myBookingBtn_MouseEnter(object sender, EventArgs e)
        {
            myBookingBtn.BackColor = Color.Red;
            myBookingImg.BackColor = Color.Red;
            myBookingLabel.BackColor = Color.Red;
        }

        private void myBookingBtn_MouseLeave(object sender, EventArgs e)
        {
            myBookingBtn.BackColor = Color.Navy;
            myBookingImg.BackColor = Color.Navy;
            myBookingLabel.BackColor = Color.Navy;
        }

        private void myBookingBtn_Click(object sender, EventArgs e)
        {
            myBookingPg myBookingPg = new myBookingPg();
            addUserControl(myBookingPg);
        }

        private void myBookingLabel_Click(object sender, EventArgs e)
        {
            myBookingPg myBookingPg = new myBookingPg();
            addUserControl(myBookingPg);
        }

        private void myBookingImg_Click(object sender, EventArgs e)
        {
            myBookingPg myBookingPg = new myBookingPg();
            addUserControl(myBookingPg);
        }

        //############################################################################
        //############################################################################

        private void ContectBtn_MouseEnter_1(object sender, EventArgs e)
        {
            ContectBtn.BackColor = Color.Red;
            ContectImg.BackColor = Color.Red;
            ContectLabel.BackColor = Color.Red;
        }

        private void ContectBtn_MouseLeave_1(object sender, EventArgs e)
        {
            ContectBtn.BackColor = Color.Navy;
            ContectImg.BackColor = Color.Navy;
            ContectLabel.BackColor = Color.Navy;
        }
        
        private void ContectBtn_Click(object sender, EventArgs e)
        {
            ContectUsPg ContectUs = new ContectUsPg();
            addUserControl(ContectUs);
        }

        private void ContectLabel_Click(object sender, EventArgs e)
        {
            ContectUsPg ContectUs = new ContectUsPg();
            addUserControl(ContectUs);
        }

        private void ContectImg_Click(object sender, EventArgs e)
        {
            ContectUsPg ContectUs = new ContectUsPg();
            addUserControl(ContectUs);
        }  

        //############################################################################
        //############################################################################
        private void AboutBtn_MouseEnter_1(object sender, EventArgs e)
        {
            AboutBtn.BackColor = Color.Red;
            AboutImg.BackColor = Color.Red;
            AboutLabel.BackColor = Color.Red;
        }

        private void AboutBtn_MouseLeave_1(object sender, EventArgs e)
        {
            AboutBtn.BackColor = Color.Navy;
            AboutImg.BackColor = Color.Navy;
            AboutLabel.BackColor = Color.Navy;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutUsPg Aboutus = new AboutUsPg();
            addUserControl(Aboutus);
        }

        private void AboutImg_Click(object sender, EventArgs e)
        {
            AboutUsPg Aboutus = new AboutUsPg();
            addUserControl(Aboutus);
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {
            AboutUsPg Aboutus = new AboutUsPg();
            addUserControl(Aboutus);
        }
        //############################################################################
        //############################################################################

        private void AdminBtn_MouseEnter_1(object sender, EventArgs e)
        {
            AdminBtn.BackColor = Color.Red;
            adminBtnImg.BackColor = Color.Red;
            AdminBtnLabel.BackColor = Color.Red;
        }

        private void AdminBtn_MouseLeave_1(object sender, EventArgs e)
        {
            AdminBtn.BackColor = Color.Navy;
            adminBtnImg.BackColor = Color.Navy;
            AdminBtnLabel.BackColor = Color.Navy;
        }

        
        private void AdminBtnLabel_Click(object sender, EventArgs e)
        {
            DeshBoard DeshBoard = new DeshBoard();
            addUserControl(DeshBoard);
        }

        private void adminBtnImg_Click(object sender, EventArgs e)
        {
            DeshBoard DeshBoard = new DeshBoard();
            addUserControl(DeshBoard);
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            DeshBoard DeshBoard = new DeshBoard();
            addUserControl(DeshBoard);
        }
        
        //###############################################################
        //###############################################################
        //   Log Out Methods
        //###############################################################

        private void LogOutBtn_MouseEnter(object sender, EventArgs e)
        {
            LogOutBtn.BackColor = Color.Red;
            LogOutImg.BackColor = Color.Red;
            LogOutLabel.BackColor = Color.Red;
        }

        private void LogOutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogOutBtn.BackColor = Color.Navy;
            LogOutImg.BackColor = Color.Navy;
            LogOutLabel.BackColor = Color.Navy;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInWindow().Show();
        }

        private void LogOutImg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInWindow().Show();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInWindow().Show();
        }

       

       
       


       
        //############################################################################
    }

}
