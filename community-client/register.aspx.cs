using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        ServiceReference1.PersonLite p = new ServiceReference1.PersonLite();
        p.firstname = FirstNameTextBox.Text;

        p.lastname = LastNameTextBox.Text;

        p.email = EmailTextBox.Text;

        p.password = ConfirmTextBox.Text;

        p.ApartmentNumber = ApartmentNumberTextBox.Text;

        p.street = StreetTextBox.Text;

        p.city = CityTextBox.Text;

        p.state = StateTextBox.Text;

        p.zipcode = ZipcodeTextBox.Text;

        p.homePhone = HomePhoneTextBox.Text;

        p.workPhone = WorkPhoneTextBox.Text;



        ServiceReference1.IcommunityAssistServiceClient sc = new ServiceReference1.IcommunityAssistServiceClient();
        

        
     

        bool result = sc.RegisterPerson(p);
        if(result)
        {

            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Things did not go quite right";

        }
    }
}
