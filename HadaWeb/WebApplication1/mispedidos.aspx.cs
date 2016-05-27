using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class mispedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["USER"] == null)
                Response.Redirect("~/inicio.aspx");
            if (GridView1.Rows.Count == 0)
                NoPedidos.Visible = true;
        }
    }
}