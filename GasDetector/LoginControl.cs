using System.Windows.Forms;

namespace GasDetector
{
    public partial class LoginControl : UserControl
    {
        MainForm _mainForm;
        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "LOGIN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mainForm.ShowRegister();
        }

        private void form2_Closed(object sender, FormClosedEventArgs e)
        {
            //this.Show();
        }
    }
}
