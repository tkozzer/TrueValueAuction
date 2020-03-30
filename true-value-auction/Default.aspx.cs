using System;
using System.Web;
using System.Web.UI;

namespace truevalueauction
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("Pages/Login.aspx");
        }
    }
}
