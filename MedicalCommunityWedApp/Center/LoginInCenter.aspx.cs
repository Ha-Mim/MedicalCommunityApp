using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalCommunityAutomation.BLL;

namespace MedicalCommunityAutomation
{
    public partial class LoginInCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CenterManager aCenterManager=new CenterManager();
        protected void centerLoginButton_Click(object sender, EventArgs e)
        {
            int centerId = aCenterManager.Find(centerCodeTextBox.Text, passwordTextBox.Text);
            if (centerId!=0)
            {
                Session["id"] = centerId;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                msgLabel.Text = "Incorrect center code or password!";
            }
        }

        protected void centerCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}