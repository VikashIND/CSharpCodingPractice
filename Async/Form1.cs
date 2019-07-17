using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestMethod();
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
          await  DownloadHtmlAsync(@"http://localhost:24499/PdfRender.aspx");
        }

        private async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var bytes =await webClient.DownloadDataTaskAsync(url);
            File.WriteAllBytes(@"c:\log\AsyncPdfTest.pdf", bytes);

        }
        private void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            //webClient.DownloadFile(url,@"c:\log\abc.pdf");

            var bytes = webClient.DownloadData(url);
            File.WriteAllBytes(@"c:\log\test1.pdf", bytes);
            //var data = Encoding.ASCII.GetString(html);
            //using(var streamWriter=new StreamWriter(@"c:\log\test.pdf"))
            //{
            //    streamWriter.Write(html);
            //}
        }

        private void TestMethod()
        {
            MessageBox.Show("Hello from winforms");
        }
    }
}
