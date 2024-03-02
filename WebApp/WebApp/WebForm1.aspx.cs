using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double p = double.Parse(TxtPrinciple.Text);
            double r = double.Parse(TxtRate.Text);
            double t = double.Parse(TxtTime.Text);
            Response.Redirect("WebForm2.aspx?p=" + p + "&r=" + r + "&t=" + t);
            // double si = (p * t * r) / 100;

            //Result.Text = "<h2> Simple Intrest= " + si + "<h2>";
        }
    }
}