using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace valideform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rfpass_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string pass = args.Value;
            if(pass.Length>=4)
                args.IsValid= true;
            else
                args.IsValid = false;

        }
    }
}