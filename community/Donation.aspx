<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donation.aspx.cs" Inherits="DonationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donations</title>
</head>
<body>
    <h1>Add Donation</h1>
    <form id="form1" runat="server">
    <div>
    <p>Donation<asp:TextBox ID="DonationTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></p>
    </div>
    </form>
</body>
</html>
