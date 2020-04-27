using System;
using System.Collections.Generic;
using System.Linq;
using truevalueauction.App_Code;
using System.Web;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace truevalueauction.Pages
{
    public partial class ViewItem : System.Web.UI.Page
    {
        HttpCookie userInfo;
        int userId, itemId;
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

            userId = int.Parse(userInfo["userId"]);
            itemId = int.Parse(Request.QueryString["itemId"]);

            string argument = Request["__EVENTARGUMENT"];
            string target = Request["__EVENTTARGET"];

            if (target == "btnPlaceBid")
            {
                btnBid_Click(argument);
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

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            string userId = userInfo["userId"];
            Response.Cookies["userId"].Value = userId;
            Response.Cookies["userId"].Expires = DateTime.Now.AddMinutes(10);
            Response.Redirect("Profile.aspx");
        }

        private void btnBid_Click(string bidStr)
        {
            double bid = double.Parse(bidStr);
            try
            {
                Database.InsertBid(bid, userId, itemId);
                alertViewItem.Text = "<div ID=\"alert\" class=\"alert alert-success text-center\"><strong>Success</strong><br/>Your bid has been placed!</div>";
            }
            catch (Exception ex)
            {

                alertViewItem.Text = "<div ID=\"alert\" class=\"alert alert-danger text-center\"><strong>Error</strong><br/>Your bid has not been placed! Please try again.</div>";
            }
            
            
        }
    }
}