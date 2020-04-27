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
        public int itemID;
        public string itemName;
        public int auctionLength;
        String imageURL;
        private DateTime dateAdded;
        private int userID;
        private String ItemCondition;
        private String itemDescription;


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
                if(x.Read()) {
                    this.itemID = x.GetInt32(0);
                    this.itemName = x.GetString(1);
                    this.itemDescription = x.GetString(2);
                    this.auctionLength = x.GetInt32(4);
                    this.imageURL = x.GetString(5);
                    this.dateAdded = x.GetDateTime(6);
                    this.ItemCondition = x.GetString(7);
                    //set local variables
                    //will need id for bid retrieval
                }
                x.Close();


                //afterwards, write them to page
                //Image1.ImageUrl = this.imageURL;


                //Retrieve current item bid
                var BidQuery = String.Format("Select top 1 [bidAmount] from [dbo].[bids] where itemid = {0} orderby bid desc", this.itemID); //replace with itemID
                var cmd = new SqlCommand(BidQuery, conn);
                var bid = (double)(cmd.ExecuteScalar());

                cmd.Dispose();

                lblCurrentBid.Text = bid.ToString("c");
                
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
            SqlConnection sqlconn = null;
            try
            {

                String cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                sqlconn = new SqlConnection(cs);


                var bidSubmitQ = String.Format("insert into [dbo].[bids] ([UserID], [ItemID], [Amount], [BidTime]) values '{0}',{1}, {2}, {3}", 0, this.itemID, this.currentBid, DateTime.Now.ToShortDateString());
                SqlCommand cmd = new SqlCommand(bidSubmitQ, sqlconn);

                cmd.ExecuteNonQuery();

            }catch (Exception z) {
                Console.WriteLine(z);
            }
            Response.Redirect("ViewItem.aspx?ItemName=" + itemName); //DO NOT FORGET TO HTML ESCAPE THIS
        }
    }
}