using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasDetector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            System.Diagnostics.Debug.WriteLine("CP1");
            InitializeComponent();
            InitializePanel();
            ShowLogin();
        }

        private void InitializePanel()
        {
            var login = new LoginControl(this);
            login.Name = "loginControl";
            panelContainer.Controls.Add(login);

            var register = new RegisterControl(this);
            register.Name = "registerControl";
            panelContainer.Controls.Add(register);

            var mainPage = new MainPageControl(this);
            mainPage.Name = "mainPageControl";
            panelContainer.Controls.Add(mainPage);
        }

        private void ShowControl(String name)
        {
            foreach (UserControl ctrl in panelContainer.Controls)
            {
                if (ctrl.Name == name)
                {
                    ctrl.Show();
                } else
                {
                    ctrl.Hide();
                }
            }
        }

        public void ShowLogin()
        {
            ShowControl("loginControl");
        }

        public void ShowRegister()
        {
            ShowControl("registerControl");
        }

        public void ShowMainPage()
        {
            ShowControl("mainPageControl");
        }
    }
}
