using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewGrant : System.Web.UI.Page
{
    ServiceReference1.IcommunityAssistServiceClient sc = new ServiceReference1.IcommunityAssistServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
            Response.Redirect("Default.aspx");
        int Key = (int)Session["UserKey"];
        ServiceReference1.GrantRequest[] requests = sc.GetGrantRequest(Key);
        GridView1.DataSource = requests;
        GridView1.DataBind();

    }

    protected void GrantDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}