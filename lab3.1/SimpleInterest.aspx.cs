using System;

namespace lab3
{
    public partial class SimpleInterest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(txtPrincipal.Text);
            double r = Convert.ToDouble(txtRate.Text);
            double t = Convert.ToDouble(txtTime.Text);

            double si = (p * r * t) / 100;

            lblResult.Text = "Simple Interest = " + si;
        }
    }
}