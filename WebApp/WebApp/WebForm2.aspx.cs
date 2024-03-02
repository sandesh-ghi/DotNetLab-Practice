using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double p = double.Parse(Request.QueryString["p"]);
            double r = double.Parse(Request.QueryString["r"]);
            double t = double.Parse(Request.QueryString["t"]);

            double si = (p * t * r) / 100;

            Result.Text = "<h2> Simple Intrest= " + si + "<h2>";
        }
    }
}