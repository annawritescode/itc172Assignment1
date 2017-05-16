using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        var dnte = (from d in db.Donations
                   select d). ToList();
        GridView1.DataSource = dnte;
        GridView1.DataBind();

    }
}