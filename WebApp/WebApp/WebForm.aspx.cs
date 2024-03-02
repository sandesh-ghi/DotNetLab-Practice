using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_ServerClick(object sender, EventArgs e)
        {
            double p = double.Parse(principle.Value);
            double r = double.Parse(rate.Value);
            double t = double.Parse(time.Value);

            double si = (p * t * r) / 100;

            Response.Write("<h2>The simple Intrest= " + si + "</h2>");

        }
    }
    
}