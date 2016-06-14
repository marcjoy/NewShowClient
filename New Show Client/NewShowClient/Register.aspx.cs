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
        RegisterVenuer
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {

    }

    protected void RegisterVenuer()
    {
        ServiceReference1.VenueLoginRegistrationServiceClient lsc =
            new ServiceReference1.VenueLoginRegistrationServiceClient();

        ServiceReference1.VenueLoginRegistrationServiceClient v = new ServiceReference1.VenueInfo();
        v.
        v.VenueName = venueNameTextBox.Text;
        v.VenueAddress = venueAddressTextBox.Text;
        v.VenueCity = venueCityTextBox.Text;
        v.VenueState = venueStateTextBox.Text;
        v.VenueZipCode = venueZipCodeTextBox.Text;
        v.VenueAgeRestriction = int.Parse(venueAgeRestrictionTextBox.Text);
        v.VenuePhone = venuePhoneTextBox.Text;
        v.VenueWebPage = venueWebPageTextBox.Text;
        v.VenueEmail = venueEmailContactTextBox.Text;
        v. = venueUserNameRegistrationTextBox.Text;
        v.VenueLoginPasswordPlain = venueRegistionPasswordTextBox.Text;

        bool result = lsc.RegisterVenue(v);

        if (result == true)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Registration Failed";
        }
    }
}