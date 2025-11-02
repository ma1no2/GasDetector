using System.Windows.Forms;

namespace GasDetector
{
    public partial class RegisterControl : UserControl
    {
        private MainForm _mainForm;
        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mainForm.ShowLogin();
        }
    }
}
