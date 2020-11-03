using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Test
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        void XYZFunction()
        {
            dynamic[] _val = new dynamic[7] { null, null, 5, 9, 15, 23, null };

            while (_val.Contains(null))
            {
                for (int i = 0; i < _val.Length - 1; i++)
                {
                    int plusVal;

                    if (i == 0 && _val[i] == null && _val[i + 1] != null)
                    {
                        plusVal = _val[i + 2] - _val[i + 1];
                        _val[i] = plusVal + (plusVal / 2);
                    }

                    else if (_val[i] != null && _val[i + 1] != null && _val[i - 1] == null)
                    {
                        plusVal = _val[i + 1] - _val[i];
                        _val[i - 1] = _val[i] - (plusVal / 2);
                    }

                    else if (_val[i] != null && _val[i + 1] == null)
                    {
                        plusVal = _val[i] - _val[i - 1];
                        _val[i + 1] = _val[i] + (i * 2);
                    }
                    else { }
                }
            }

            string X = _val[0];
            string Y = _val[1];
            string Z = _val[6];

            string Result = "";
            for (int i = 0; i < _val.Length; i++)
            {
                Result += _val[i].ToString() + "  ";
            }

            //label1.Text = "The result is " + Result;
        }

        void ABCFucntion(int valA, int valAplusB, int valAplusC)
        {
            int valB = valAplusB - valA;
            int valC = valAplusC - valA;

            //label1.Text = "B Value is " + valB.ToString() + " and C Value is " + valC.ToString();
        }

        private void lbXYZ_Click(object sender, EventArgs e)
        {
            lbXYZ.Font = new Font(lbXYZ.Font, FontStyle.Bold);

            lbABC.Font = new Font(lbABC.Font, FontStyle.Regular);
            lbGoogle.Font = new Font(lbGoogle.Font, FontStyle.Regular);
            lbCV.Font = new Font(lbCV.Font, FontStyle.Regular);


            FindXYZ xyz = new FindXYZ();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(xyz);
        }

        private void lbABC_Click(object sender, EventArgs e)
        {
            lbABC.Font = new Font(lbABC.Font, FontStyle.Bold);

            lbXYZ.Font = new Font(lbXYZ.Font, FontStyle.Regular);
            lbGoogle.Font = new Font(lbGoogle.Font, FontStyle.Regular);
            lbCV.Font = new Font(lbCV.Font, FontStyle.Regular);

            FindABC abc = new FindABC();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(abc);
        }

        private void lbGoogle_Click(object sender, EventArgs e)
        {
            lbGoogle.Font = new Font(lbGoogle.Font, FontStyle.Bold);

            lbXYZ.Font = new Font(lbXYZ.Font, FontStyle.Regular);
            lbABC.Font = new Font(lbABC.Font, FontStyle.Regular);
            lbCV.Font = new Font(lbCV.Font, FontStyle.Regular);

            GoogleMapAPI map = new GoogleMapAPI();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(map);
        }

        private void lbCV_Click(object sender, EventArgs e)
        {
            lbCV.Font = new Font(lbCV.Font, FontStyle.Bold);

            lbXYZ.Font = new Font(lbXYZ.Font, FontStyle.Regular);
            lbGoogle.Font = new Font(lbGoogle.Font, FontStyle.Regular);
            lbABC.Font = new Font(lbABC.Font, FontStyle.Regular);

            CVInfo cv = new CVInfo();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(cv);
        }

       
    }
}
