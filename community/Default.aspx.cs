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

    protected void LogInButton1_click(object sender, EventArgs e)
    {
        int key = 0;
        Community_AssistEntities db = new Community_AssistEntities();
        int success = db.usp_Login(UserTextBox.Text, PasswordTextBox.Text);
        if(success != -1)
        {
            var userKey = (from K in db.People
                           where K.PersonEmail.Equals(UserTextBox.Text)
                           select K.PersonKey).FirstOrDefault();

            key = (int)userKey;
            Session["userKey"] = key;
            Response.Redirect("Donation");
        

        }
        else
        {
            ResultLabel1.Text = "Invalid Login";
        }
    }
}