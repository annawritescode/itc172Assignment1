using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton1_Click(object sender, EventArgs e)
    {
        ServiceReference1.IcommunityAssistServiceClient sc = new ServiceReference1.IcommunityAssistServiceClient();

        int result = sc.Login(UserTextBox.Text, PasswordTextBox.Text);

        if(result != 0)
        {

            Session["userKey"] = result;
            ResultLabel1.Text = "Welcome";


        }
        else
        {
            ResultLabel1.Text = "Invalid Login";
        }
    }
}