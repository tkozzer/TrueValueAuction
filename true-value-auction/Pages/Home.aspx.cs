using System;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace truevalueauction.Pages
{

    public partial class Home : System.Web.UI.Page
    {
        private static HttpCookie userInfo;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["userInfo"] != null)
            {
                userInfo = Request.Cookies["userInfo"];
            } else
            {
                btnLogout_Click(sender, e);
            }

            if (!IsPostBack)
            {
                if (userInfo["isAuth"] == null || userInfo["isAuth"] == "false")
                {
                    isAuthLiteral.Text = "<div class=\"h1\">Cookies are null</div>";
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    if (userInfo["userId"] != null)
                    {
                        isAuthLiteral.Text = "<div class=\"h1\">"+ userInfo["isAuth"] + "</div>";
                        userIdLiteral.Text = "<div class=\"h1\">userId: " + userInfo["userId"] + "</div>";
                    }
                    else
                    {
                        userIdLiteral.Text = "<div class=\"h1\">userId: null </div>";
                    }
                }
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            userInfo["isAuth"] = "false";
            userInfo["userId"] = null;
            userInfo.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(userInfo);
            Response.Redirect("Login.aspx");
        }

        protected void btnAddNewItem_Click(object sender, EventArgs e)
        {
            if (userInfo == null) btnLogout_Click(sender, e);
            Response.Redirect("AddNewItem.aspx");
        }
    }
}
