﻿using System;
using System.Web;

namespace AcyncUpdate.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("~/AsyncUpdateView.wgx", true);
        }
    }
}