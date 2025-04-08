using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass2025_04_08
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmdOK.Click += cmdOK_OnClick;
        }
        protected void cmdOK_OnClick(object sender, EventArgs e)
        {
            //call your .cs file code here
            lblResult.Text = "You clicked!";

            DateTime date1 = calCheckInDate.SelectedDate;
            DateTime date2 = calCheckInDate.SelectedDate;

            int daysDifference = (date2-date1).Days;

            lblResult.Text = "Total: " + ((daysDifference * 200) + ((daysDifference * 200) * 0.15));
        }
    }
}