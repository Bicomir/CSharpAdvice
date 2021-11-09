using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetPage_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                var url = "https://www.cnblogs.com/luminji/";
                var request = HttpWebRequest.Create(url);
                var response = request.GetResponse();
                var stream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream))
                {
                    var content = reader.ReadLine();
                    textBoxPage.Text = content;
                }
            });
            t.Start();
        }
    }
}
