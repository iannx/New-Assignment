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
    public partial class FindABC : UserControl
    {
        public FindABC()
        {
            InitializeComponent();
        }

        private void FindABC_Load(object sender, EventArgs e)
        {
            label2.Text = "A = 21";
            label3.Text = "A + B = 23";
            label4.Text = "C = -21";

            label5.Text = "";
            label6.Text = "";
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            ABCFucntion(21, 23, -21);
        }

        void ABCFucntion(int valA, int valAplusB, int valAplusC)
        {
            int valB = valAplusB - valA;
            int valC = valAplusC - valA;

            label5.Text = "B Solve Value is " + valB.ToString();
            label6.Text = "C Solve Value is " + valC.ToString();
        }
    }
}
