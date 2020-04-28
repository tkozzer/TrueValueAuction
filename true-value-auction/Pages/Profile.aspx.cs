using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using truevalueauction.App_Code;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace truevalueauction.Pages
{
    public partial class Profile : System.Web.UI.Page
    {
        HttpCookie userInfo;
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
            //Response.Cookies["userId"].Value = 2.ToString();


            string argument = Request["__EVENTARGUMENT"];
            string target = Request["__EVENTTARGET"];

            if (target == "btnDeleteItem")
            {
                btnDeleteItem_Click(argument);
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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            if (userInfo["isAuth"] == "true")
            {
                Response.Redirect("Home.aspx");
            }

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

        protected void btnEditAddress_Click(object sender, EventArgs e)
        {

        }

        protected void btnDeleteItem_Click(string id)
        {
            int itemId = int.Parse(id);
            int userId = int.Parse(userInfo["userId"]);

            try
            {
                Database.DeleteItem(userId, itemId);
                alertProfile.Text = "<div ID=\"alert\" class=\"alert alert-success text-center\"><strong>Success</strong><br/>Your item has been deleted</div>";
            }
            catch (Exception)
            {

                alertProfile.Text = "<div ID=\"alert\" class=\"alert alert-danger text-center\"><strong>Error</strong><br/>You cannot delete an item if it has bids.</div>";
            }
            

        }

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(userInfo["userId"]);

            try
            {
                Database.DeleteAccount(userId);
                alertProfile.Text = "<div ID=\"alert\" class=\"alert alert-success text-center\"><strong>Success</strong><br/>Your account has been deleted</div>";
                btnLogout_Click(sender, e);
            }
            catch (Exception)
            {

                alertProfile.Text = "<div ID=\"alert\" class=\"alert alert-danger text-center\"><strong>Error</strong><br/>There seems to be problem deleting this account. If you have active auctions or bids,<br/> you must wait till they expire.</div>";
            }


        }

    }
}