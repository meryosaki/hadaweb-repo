using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Microsoft;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Web.UI.HtmlControls;


namespace WebApplication1
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
                Response.Redirect("~/inicio.aspx");
            if (GridView1.Rows.Count == 0)
            {
                NoPedidos.Visible = true;
                Importe.Visible = false;
                Label1.Visible = false;
                Label3.Visible = false;
            }
            else
            {
                double precioTotal = 0;
                string precioActual = "";
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    precioActual = GridView1.Rows[i].Cells[4].Text;
                    precioTotal += Convert.ToDouble(precioActual);
                }
                NoPedidos.Visible = false;
                Importe.Visible = true;
                Label1.Visible = true;
                Label3.Visible = true;
                Importe.Text = precioTotal.ToString();
            }
        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("forma-pago.aspx");
        }

        protected void PDF_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";  
            Response.AddHeader("content-disposition", "attachment;filename=Factura_Servirent.pdf");  
            Response.Cache.SetCacheability(HttpCacheability.NoCache);  
            StringWriter sw = new StringWriter();  
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Page page = new Page();
            HtmlForm form = new HtmlForm();
            GridView1.EnableViewState = false;
            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;
            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();
            page.Controls.Add(form);
            form.Controls.Add(GridView1);
            page.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());  
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);  
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);  
            pdfDoc.Open();  
            htmlparser.Parse(sr);  
            pdfDoc.Close();  
            Response.Write(pdfDoc);  
            Response.End();  
            GridView1.AllowPaging = true;
            GridView1.DataBind();
        }
    }
}