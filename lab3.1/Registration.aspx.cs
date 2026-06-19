using System;

namespace lab3
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMessage.Text =
                "Registration Successful";
            }
            else
            {
                lblMessage.Text =
                "Please enter valid details";
            }
        }
    }
}