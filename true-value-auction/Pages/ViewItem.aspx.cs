using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace truevalueauction.Pages
{
    public partial class ViewItem : System.Web.UI.Page
    {
        HttpCookie userInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            string itemId = Request.QueryString["itemId"];
            Debug.WriteLine("itemId: " + itemId);
            alertViewItem.Text = "<div ID=\"alert\" class=\"alert alert-danger text-center\"><strong>"+itemId+"</strong></div>";

            if (Request.Cookies["userInfo"] != null)
            {
                userInfo = Request.Cookies["userInfo"];
            }
            else
            {
                btnLogout_Click(sender, e);
            }
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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            if (userInfo["isAuth"] == "true")
            {
                Response.Redirect("Home.aspx");
            }

        }
    }
}