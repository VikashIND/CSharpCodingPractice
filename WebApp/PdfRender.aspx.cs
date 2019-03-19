using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class PdfRender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RenderPdf();
        }

        private void RenderPdf()
        {
            string FilePath = Server.MapPath("~/Docs/receipt.pdf");
            WebClient User = new WebClient();
            Byte[] FileBuffer = User.DownloadData(FilePath);
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.BinaryWrite(FileBuffer);
            }
        }
    }
}