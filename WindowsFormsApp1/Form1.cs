using System;
using System.IO;
using System.Net;
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
            var url = "https://www.cnblogs.com/luminji/";
            var request = HttpWebRequest.Create(url);
            request.BeginGetResponse(this.AsyncCallbackImpl, request);
        }

        private void AsyncCallbackImpl(IAsyncResult ar)
        {
            WebRequest request = ar.AsyncState as WebRequest;
            var response = request.EndGetResponse(ar);
            var stream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream))
            {
                var content = reader.ReadLine();
                textBoxPage.Text = content;
            }
        }
    }
}
