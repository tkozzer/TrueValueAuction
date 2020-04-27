using System;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using truevalueauction.App_Code;

namespace truevalueauction.Pages
{

    public partial class Home : System.Web.UI.Page
    {
        private static HttpCookie userInfo;
        private static string dataSourceId;
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.GetPostBackEventReference(this, string.Empty);
            if (Request.Cookies["userInfo"] != null)
            {
                userInfo = Request.Cookies["userInfo"];
            }
            else
            {
                btnLogout_Click(sender, e);
            }

            if (dataSourceId == null)
            {
                dataSourceId = ListItems.DataSourceID;
            }

            string argument = Request["__EVENTARGUMENT"];
            string target = Request["__EVENTTARGET"];

            if(target == "bidClick")
            {
                btnBid_Click(argument);
            }

            if (!IsPostBack)
            {

                //if (userInfo["isAuth"] == null || userInfo["isAuth"] == "false")
                //{
                //    isAuthLiteral.Text = "<div class=\"h1\">Cookies are null</div>";
                //    Response.Redirect("Home.aspx");
                //}
                //else
                //{
                //    if (userInfo["userId"] != null)
                //    {
                //        isAuthLiteral.Text = "<div class=\"h1\">"+ userInfo["isAuth"] + "</div>";
                //        userIdLiteral.Text = "<div class=\"h1\">userId: " + userInfo["userId"] + "</div>";
                //    }
                //    else
                //    {
                //        userIdLiteral.Text = "<div class=\"h1\">userId: null </div>";
                //    }
                //}
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (userInfo != null)
            {
                userInfo["isAuth"] = "false";
                userInfo["userId"] = null;
                userInfo.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(userInfo);
            }
            Response.Redirect("Login.aspx");

        }

        protected void btnAddNewItem_Click(object sender, EventArgs e)
        {
            if (userInfo == null) btnLogout_Click(sender, e);
            Response.Redirect("AddNewItem.aspx");
        }

        protected string GetTimeRemaining(object auctionLength, object dateAdded)
        {
            double timeRemaining = 0;
            string timeType = "days";
            if (auctionLength != null && dateAdded != null)
            {

                DateTime now = DateTime.Now;
                DateTime added = (DateTime)dateAdded;
                int duration = (int)auctionLength;

                DateTime end = added.AddDays(duration);

                timeRemaining = (end - now).TotalDays;
                if (timeRemaining < 1)
                {
                    timeType = "hours";
                    timeRemaining = (end - now).TotalHours;
                    if (timeRemaining < 1)
                    {
                        timeType = "minutes";
                        timeRemaining = (end - now).TotalMinutes;
                        if (timeRemaining < 1)
                        {
                            timeType = "seconds";
                            timeRemaining = (end - now).TotalSeconds;
                        }
                    }
                }

            }

            return string.Format("{0} {1}", Convert.ToInt32(timeRemaining), timeType);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;

            DataTable searchResults = Database.SearchItems(searchQuery);
            if (searchResults.Rows.Count != 0)
            {
                ListItems.DataSource = searchResults;
                ListItems.DataSourceID = null;
                ListItems.DataBind();
                alertHome.Text = "";
            }
            else
            {
                alertHome.Text = "<div ID=\"alert\" class=\"alert alert-danger text-center\"><strong>No items match your search</strong></div>";
                ListItems.DataSourceID = dataSourceId;
                ListItems.DataSource = null;
            }
        }

        protected void btnBid_Click(string argument)
        {
            Response.Redirect("ViewItem.aspx?itemId=" + argument );
        }


    }
}
