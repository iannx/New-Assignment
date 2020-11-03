using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace WinApp_Test
{
    public partial class GoogleMapAPI : UserControl
    {
        public GoogleMapAPI()
        {
            InitializeComponent();

            //GetGoogleMapAPI();
        }

        private void GoogleMapAPI_Load(object sender, EventArgs e)
        {
           
        }

        private void GetGoogleMapAPI()
        {
            try
            {            
                if (txtStart.Text != "" && txtDestination.Text != "")
                {
                    //StringBuilder qryAddr = new StringBuilder();
                    //qryAddr.Append("https://www.google.com/maps/dir/SCG+%E0%B8%AA%E0%B8%B3%E0%B8%99%E0%B8%B1%E0%B8%81%E0%B8%87%E0%B8%B2%E0%B8%99%E0%B9%83%E0%B8%AB%E0%B8%8D%E0%B9%88+%E0%B8%9A%E0%B8%B2%E0%B8%87%E0%B8%8B%E0%B8%B7%E0%B9%88%E0%B8%AD+%E0%B8%8B%E0%B8%AD%E0%B8%A2+%E0%B8%9B%E0%B8%B9%E0%B8%99%E0%B8%8B%E0%B8%B5%E0%B9%80%E0%B8%A1%E0%B8%99%E0%B8%95%E0%B9%8C%E0%B9%84%E0%B8%97%E0%B8%A2+%E0%B9%81%E0%B8%82%E0%B8%A7%E0%B8%87+%E0%B8%9A%E0%B8%B2%E0%B8%87%E0%B8%8B%E0%B8%B7%E0%B9%88%E0%B8%AD+%E0%B9%80%E0%B8%82%E0%B8%95%E0%B8%9A%E0%B8%B2%E0%B8%87%E0%B8%8B%E0%B8%B7%E0%B9%88%E0%B8%AD+%E0%B8%81%E0%B8%A3%E0%B8%B8%E0%B8%87%E0%B9%80%E0%B8%97%E0%B8%9E%E0%B8%A1%E0%B8%AB%E0%B8%B2%E0%B8%99%E0%B8%84%E0%B8%A3/%E0%B9%80%E0%B8%8B%E0%B9%87%E0%B8%99%E0%B8%97%E0%B8%A3%E0%B8%B1%E0%B8%A5%E0%B9%80%E0%B8%A7%E0%B8%B4%E0%B8%A5%E0%B8%94%E0%B9%8C+999%2F9+%E0%B8%96%E0%B8%99%E0%B8%99+%E0%B8%9E%E0%B8%A3%E0%B8%B0%E0%B8%A3%E0%B8%B2%E0%B8%A1%E0%B8%97%E0%B8%B5%E0%B9%88+%E0%B9%91+%E0%B9%81%E0%B8%82%E0%B8%A7%E0%B8%87+%E0%B8%9B%E0%B8%97%E0%B8%B8%E0%B8%A1%E0%B8%A7%E0%B8%B1%E0%B8%99+%E0%B9%80%E0%B8%82%E0%B8%95%E0%B8%9B%E0%B8%97%E0%B8%B8%E0%B8%A1%E0%B8%A7%E0%B8%B1%E0%B8%99+%E0%B8%81%E0%B8%A3%E0%B8%B8%E0%B8%87%E0%B9%80%E0%B8%97%E0%B8%9E%E0%B8%A1%E0%B8%AB%E0%B8%B2%E0%B8%99%E0%B8%84%E0%B8%A3+10330/@13.774411,100.5182045,14z/data=!3m1!4b1!4m13!4m12!1m5!1m1!1s0x30e29c73a688957b:0x70f4e8a5223e44a0!2m2!1d100.5375317!2d13.8058793!1m5!1m1!1s0x30e29ecfc2f455e1:0xc4ad0280d8906604!2m2!1d100.5393351!2d13.7466304");

                    //webBrowser1.Navigate(qryAddr.ToString());

                    string Key = "AIzaSyBRhXZNso6fFmkPAyHSlq6-uGDDShJ62y4";

                    WebRequest req = WebRequest.Create(@"https://maps.googleapis.com/maps/api/directions/json?origin=" + txtStart.Text +
                        "&destination=" + txtDestination.Text + "&key=" + Key);
                    req.Method = "GET";
                    req.ContentType = "application/json; charset=utf-8";
                    string clientinfo = "";

                    WebResponse resp = req.GetResponse();
                    using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                    {
                        clientinfo = sr.ReadToEnd();
                        JObject o = JObject.Parse(clientinfo);

                        //sent Json to Get Route
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลสถานที่ที่ท่านต้องการค้นหา");
                }
            }

            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetGoogleMapAPI();
        }
    }
}
