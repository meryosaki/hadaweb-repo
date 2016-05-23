using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Buton_Click(object sender, EventArgs e)
        {
            string b = buscador.Text;
            string op = DropDownList1.Text;

            if (op == "Cursos")
            {
                Response.Redirect("cursos.aspx?b=" + b);
            }
            else
            {
                Response.Redirect("ofertas.aspx?b=" + b);
            }


        }
    }
    
}