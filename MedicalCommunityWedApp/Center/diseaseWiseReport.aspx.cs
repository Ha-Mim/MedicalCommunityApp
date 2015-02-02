using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalCommunity.BLL;
using MedicalCommunityAutomation.BLL;

namespace MedicalCommunityWedApp.Center
{
    public partial class diseaseWiseReport : System.Web.UI.Page
    {
        DiseaseManager aDiseaseManager =new DiseaseManager();
        TreatmentManager aTreatmentManager = new TreatmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                diseaseDropDownList.DataSource = aDiseaseManager.GetAll();
                diseaseDropDownList.DataTextField = "Name";
                diseaseDropDownList.DataValueField = "Id";
                diseaseDropDownList.DataBind();

                //firstDateDropDownList.DataSource = aTreatmentManager.GetAllDate();
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {

        }
    }
}