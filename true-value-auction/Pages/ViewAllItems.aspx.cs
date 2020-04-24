using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace truevalueauction.Pages
{
    public partial class ViewAllItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void grdVwItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow r = grdVwItems.SelectedRow;
            string itemName = r.Cells[2].Text;
            Response.Redirect("ViewItem.aspx?itemName=" + itemName); //HTML ESCAPE THIS
        }
    }
}