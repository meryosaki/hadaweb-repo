﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class curso_damas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonReservar(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
                Response.Redirect("~/identificarse.aspx");
            else if (Session["USER"] != null)
                Response.Redirect("~/micarrito.aspx");
        }
    }
}