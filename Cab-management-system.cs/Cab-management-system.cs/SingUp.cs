using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cab_management_system;
//using System.Web.Http;


namespace Cab_management_system.cs
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent(); Opacity = 0.95;
        }

        //private String dataGet() {
        //    var url = "https://cabdababaseapi.chomboss.repl.co/Api";
        //    var httpRequest = (HttpWebRequest)WebRequest.Create(url);
        //    httpRequest.Method = "POST";
        //    httpRequest.Accept = "application/json";
        //    httpRequest.ContentType = "";
        //    httpRequest.Headers["Content-Length"] = "0";

        //    var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //    {
        //        var result = streamReader.ReadToEnd();
        //    }
        //    Console.WriteLine(httpResponse.StatusCode);
        //}


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlreadyAccountLabel_Click(object sender, EventArgs e)
        {
            new LogInWindow().Show();
            this.Hide();
        }

        private void SIngUpImgBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserId.Text + "\n" + PassWord.Text + "\n" + ConformPass);
        }

        private void feildClearLabel_Click(object sender, EventArgs e)
        {
            UserId.Clear();
            PassWord.Clear();
            ConformPass.Clear();
        }

        private void LostPass_MouseEnter(object sender, EventArgs e)
        {
            LostPass.ForeColor = Color.Blue;
        }

        private void LostPass_MouseLeave(object sender, EventArgs e)
        {
            LostPass.ForeColor = Color.Black;
        }

        private void AlreadyAccountLabel_MouseEnter(object sender, EventArgs e)
        {
            AlreadyAccountLabel.ForeColor = Color.Blue;
        }

        private void AlreadyAccountLabel_MouseLeave(object sender, EventArgs e)
        {
            AlreadyAccountLabel.ForeColor = Color.Black;
        }

        private void feildClearLabel_MouseEnter(object sender, EventArgs e)
        {
            feildClearLabel.ForeColor = Color.Red;
        }

        private void feildClearLabel_MouseLeave(object sender, EventArgs e)
        {
            feildClearLabel.ForeColor = Color.Black;
        }

        private void LostPass_Click(object sender, EventArgs e)
        {

        }

        
    }
}