using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        
        string firstname = FirstNameTextBox.Text;
        string lastname = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;
        string apartmentNumber = ApartmentNumberTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string Zipcode = ZipcodeTextBox.Text;
        string homePhone = HomePhoneTextBox.Text;
        string workPhone = WorkPhoneTextBox.Text;

        Community_AssistEntities db = new Community_AssistEntities();
        int result = db.usp_Register( lastname, firstname, email,
            password, apartmentNumber, street, city, state,
            Zipcode, homePhone, workPhone);
       
    }
}