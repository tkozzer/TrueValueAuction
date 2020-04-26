using System;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace truevalueauction.Pages
{

    public partial class Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs args)
        {

             if(Request.Cookies["isAuth"] != null)
            {
                if (Request.Cookies["isAuth"].Value == "true" && Request.QueryString["userId"] != null)
                {
                    isAuth.Text = "<div class=\"h1\">isAuth: \"true\"</div>";
                }
                else
                {
                    Response.Cookies["isAuth"].Expires = DateTime.Now.AddDays(-1d);
                    isAuth.Text = "<div class=\"h1\">isAuth: \"false\"</div>";
                }
            } else
            {
                isAuth.Text = "<div class=\"h1\">Cookies are null</div>";
            }

             if(Request.QueryString["userId"] != null)
            {
                string userId = Request.QueryString["userId"];
                userIdLiteral.Text = "<div class=\"h1\">userId: " + userId  + "</div>";
            } else
            {
                userIdLiteral.Text = "<div class=\"h1\">userId: null </div>";
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["isAuth"].Value = "false";
            Response.Cookies["isAuth"].Expires = DateTime.Now.AddDays(-1d);
            Response.Redirect("Login.aspx");
        }
    }
}
