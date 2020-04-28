using System;
using System.Web;
using System.Web.UI;
using truevalueauction.App_Code;

namespace truevalueauction.Pages
{

    public partial class AddNewItem : System.Web.UI.Page
    {
        private static HttpCookie userInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.GetPostBackEventReference(this, string.Empty);
            if (!IsPostBack)
            {
                if (Request.Cookies["userInfo"] != null)
                {
                    userInfo = Request.Cookies["userInfo"];
                }
                else
                {
                    btnLogout_Click(sender, e);
                }
            }
            string target = Request["__EVENTTARGET"];
            if (target == "btnSubmit")
            {
                btnSubmit_Click(sender, e);
            }


        }

        private bool ValidateImage()
        {

            HttpPostedFile theFile = fileUpload.PostedFile;
            if (!theFile.FileName.Contains(".png") || !theFile.FileName.Contains(".jpg"))
            {
                return false;
            }

            return true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string itemName, itemDesc, itemCondition, itemFile;
            double itemPrice;
            int auctionLength;
            AuctionItem item;

            itemName = txtItemName.Text;
            itemDesc = txtDescription.Text;
            itemCondition = ddCondition.SelectedValue;
            itemPrice = double.Parse(txtStartBid.Text);
            itemFile = fileUpload.FileName;
            auctionLength = int.Parse(txtAuctionLength.Text);

            item = new AuctionItem(itemName, itemDesc, itemPrice, auctionLength, itemCondition, itemFile);

            try
            {
                if (!ValidateImage()) throw new ArgumentException("Please make sure your file upload is either a .png or .jpg");
                Database.InsertItem(item, int.Parse(userInfo["userId"]));
                ClearFields();
                alertNewItem.Text = "<div ID=\"alert\" class=\"alert alert-success\"><div class:\"h3\"><strong>Success</strong></div>Item was added and auction is now live!</div>";

            }
            catch(ArgumentException ex)
            {
                alertNewItem.Text = "<div ID=\"alert\" class=\"alert alert-danger\"><div class:\"h3\"><strong>Add Item Error</strong></div>"+ex.Message+"</div>";
            }
            catch (Exception)
            {
                alertNewItem.Text = "<div ID=\"alert\" class=\"alert alert-danger\"><div class:\"h3\"><strong>Add Item Error</strong></div>There was an error adding you item</div>";

            }

        }


        protected void btnHome_Click(object sender, EventArgs e)
        {
            if (userInfo["isAuth"] == "true")
            {
                Response.Redirect("Home.aspx");
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if(userInfo != null)
            {
                userInfo["isAuth"] = "false";
                userInfo["userId"] = null;
                userInfo.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(userInfo);
            }
            Response.Redirect("Login.aspx");

        }

        private void ClearFields()
        {
            txtItemName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStartBid.Text = string.Empty;
            txtAuctionLength.Text = string.Empty;
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            string userId = userInfo["userId"];
            Response.Cookies["userId"].Value = userId;
            Response.Cookies["userId"].Expires = DateTime.Now.AddMinutes(10);
            Response.Redirect("Profile.aspx");
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    //ValidateInput(); //calls other validation
        //}

        ////private void ValidateInput()
        ////{

        ////    ValidateText();
        ////    ValidateNumbers();
        ////    ValidateImage();

        ////}

        ////private void ValidateImage()
        ////{

        ////    HttpPostedFile theFile = fileImage.PostedFile;
        ////    if (!theFile.FileName.Contains(".png") || !theFile.FileName.Contains(".jpg"))
        ////    {
        ////        lblImageError.Text = "File must be a .png or .jpg file";
        ////    }
        ////}

        ////private void ValidateText()
        ////{
        ////    String itemName = txtItemName.Text;
        ////    String itemDescription = txtDesc.Text;

        ////    if (itemName == "")
        ////    {
        ////        lblNameError.Text = "**Item Name cannot be empty";
        ////    }
        ////    if (itemDescription == "")
        ////    {
        ////        lblDescriptionError.Text = "**Item needs a description";
        ////    }

        ////}
        ////private void ValidateNumbers()
        ////{

        ////    try
        ////    {
        ////        Double startingPrice = Double.Parse(txtStartingPrice.Text);
        ////        if (startingPrice <= 0) { lblStartingPriceError.Text = "**Starting price cannot be equal to or less than zero. "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblStartingPriceError.Text += ("**Please format price as \"x.yz\"");
        ////    }

        ////    try
        ////    {
        ////        int bidLength = int.Parse(txtBidLength.Text);
        ////        if (bidLength <= 0) { lblStartingPriceError.Text = "**Bid length cannot be equal to or less than zero. Must be less than 10. "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblStartingPriceError.Text += ("**Please format bid length as a single number less than or equal to 10 ");
        ////    }

        ////    try
        ////    {
        ////        double shippingHeight = double.Parse(txtShipHeight.Text);
        ////        if (shippingHeight < 0) { lblShipHeightError.Text = "**Please enter an integer greater than zero "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblShipHeightError.Text += "**Please enter the number as \"x.yz\"";
        ////    }

        ////    try
        ////    {
        ////        double shippingLength = double.Parse(txtShipLength.Text);
        ////        if (shippingLength < 0) { lblShipLengthError.Text = "**Please enter an integer greater than zero "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblShipLengthError.Text += "**Please enter the number as \"x.yz\"";
        ////    }

        ////    try
        ////    {
        ////        double shippingDepth = double.Parse(txtShipDepth.Text);
        ////        if (shippingDepth < 0) { lblShipDepthError.Text = "**Please enter an integer greater than zero "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblShipDepthError.Text += "**Please enter the number as \"x.yz\"";
        ////    }

        ////    try
        ////    {
        ////        double shippingWeight = double.Parse(txtShipWeight.Text);
        ////        if (shippingWeight <= 0) { lblShipWeightError.Text = "**Please enter an integer greater than zero "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblShipWeightError.Text += "**Please enter the number as \"x.yz\"";
        ////    }

        ////    try
        ////    {
        ////        double shippingCost = double.Parse(txtShipWeight.Text);
        ////        if (shippingCost <= 0) { lblShipCostError.Text = "**Please enter an integer greater than zero "; }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        lblShipCostError.Text += "**Please enter the number as \"x.yz\"";
        ////    }

        ////}
    }
}