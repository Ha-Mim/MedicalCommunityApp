using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalCommunityAutomation.BLL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityWedApp.HeadOffice
{
    public partial class LoginCodePassword : System.Web.UI.Page
    {
        CenterManager aCenterManager=new CenterManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["code"].ToString();
            MedicalCommunityAutomation.DAO.Center aCenter = aCenterManager.GetCenterByName(name);
            codeTextBox.Text= aCenter.Code;
            passwordTextBox.Text = aCenter.Password;
        }

        protected void codePasswordGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}