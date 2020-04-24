using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace truevalueauction.Pages
{
    public partial class ViewItem : System.Web.UI.Page
    {

        public double currentBid = 0;
        public double itemName;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["itemName"] != null) {
                //retrieve item details
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

                String query = String.Format("Select * from items where name = {'0'}", Request.QueryString["itemName"]);

                SqlCommand z = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader x = z.ExecuteReader();

                //write item details to Page
                while (x.Read()) {
                    //set local variables
                    //will need id for bid retrieval
                }
                //afterwards, write them to page

                var ItemID = 0;
                //Retrieve current item bid
                var BidQuery = String.Format("Select bidAmount from bids where itemid = {0}", ItemID); //replace with itemID


                //set current item bid
            }
        }

        private void ValidateBid() {
            double bid = 0;
            try
            {
                bid = Double.Parse(txtNewBid.Text);

                currentBid = bid;
                lblCurrentBid.Text = currentBid.ToString("c");
            }
            catch (Exception ex)
            {

                lblBidError.Text = "Cannot parse bid. Be sure to enter it in the 'x.yz' format";
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateBid();
            Response.Redirect("ViewItem.aspx?ItemName=" + itemName); //DO NOT FORGET TO HTML ESCAPE THIS
        }
    }
}