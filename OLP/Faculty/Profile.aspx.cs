﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Faculty_Profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink ProfileId = (HyperLink)Master.FindControl("ProfileId");
        ProfileId.CssClass = "active";
    }
}