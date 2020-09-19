using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kayak
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LblConfirmation.Text = "You Selected " + RdbList.SelectedValue.ToString()
                + " using a " + DrpList.SelectedValue.ToString() +
                " on " + Cal.SelectedDate.ToString() +
                " with the following equipment " + ChkBoxList.SelectedValue.ToString()+".";
        }
    }
}