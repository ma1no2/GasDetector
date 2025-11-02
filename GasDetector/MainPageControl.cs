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
    public partial class MainPageControl : UserControl
    {
        MainForm _mainForm;
        public MainPageControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
    }
}
