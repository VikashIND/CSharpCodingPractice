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
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadHtml(@"http://localhost:24499/PdfRender.aspx");
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
    }
}
