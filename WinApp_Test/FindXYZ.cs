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
    public partial class FindXYZ : UserControl
    {
        public FindXYZ()
        {
            InitializeComponent();
        }

        private void FindXYZ_Load(object sender, EventArgs e)
        {
            label2.Text = "X    Y    5    9    15    23    Z";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XYZFunction();
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

            string X = _val[0].ToString();
            string Y = _val[1].ToString();
            string Z = _val[6].ToString();
            string Result = "";

            for (int i = 0; i < _val.Length; i++)
            {
                Result += _val[i].ToString() + "    ";
            }

            label3.Text = Result;
            label4.Text = "X = " + X;
            label5.Text = "Y = " + Y;
            label6.Text = "Z = " + Z;
        }


    }
}
