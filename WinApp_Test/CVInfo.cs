using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Test
{
    public partial class CVInfo : UserControl
    {
        public CVInfo()
        {
            InitializeComponent();

            StringBuilder qryAddr = new StringBuilder();
            qryAddr.Append("https://drive.google.com/file/d/1iqMM1Wuq9xIE-W22aXno3rdAu3JpR1IE/view?usp=sharing");

            webBrowser1.Navigate(qryAddr.ToString());
        }

        private void CVInfo_Load(object sender, EventArgs e)
        {
            
        }

    }
}
