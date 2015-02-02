using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using MedicalCommunity.BLL;
using MedicalCommunity.DAO;
using MedicalCommunityAutomation.BLL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityWedApp.Center
{
    public partial class treatmentGiven : System.Web.UI.Page
    {
        DoctorManager aDoctorManager=new DoctorManager();
        DiseaseManager aDiseaseManager = new DiseaseManager();
        MedicineManager aMedicineManager = new MedicineManager();
        DoseManager aDoseManager = new DoseManager();
        TreatmentManager aTreatmentManager=new TreatmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int centerId = Convert.ToInt32(Session["id"]);
            if (!IsPostBack)
            {
                doctorDropDownList.DataSource = aDoctorManager.GetAll(centerId);
                doctorDropDownList.DataTextField = "Name";
                doctorDropDownList.DataValueField = "Id";
                doctorDropDownList.DataBind();

                diseaseDropDownList.DataSource = aDiseaseManager.GetAll();
                diseaseDropDownList.DataTextField = "Name";
                diseaseDropDownList.DataValueField = "Id";
                diseaseDropDownList.DataBind();

                medicineDropDownList.DataSource = aMedicineManager.GetAllMedicine();
                medicineDropDownList.DataTextField = "Name";
                medicineDropDownList.DataValueField = "Id";
                medicineDropDownList.DataBind();

                doseDropDownList.DataSource = aDoseManager.GetAll();
                doseDropDownList.DataTextField = "Time";
                doseDropDownList.DataValueField = "Id";
                doseDropDownList.DataBind();

            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string msg = "";

            var diseaseList = disease.Value;
            disease.Value = "";
            string[] diseaseName = diseaseList.Split(',');

            var mediceneList = medicine.Value;
            disease.Value = "";
            string[] medicineName = mediceneList.Split(',');

            var quantityList = quantity.Value;
            quantity.Value = "";
            string[] quantityValue = quantityList.Split(',');

            //    for (int i = 0; i < diseaseName.Length - 1; i++)
            //    {
            //        Medicine aMedicine = aMedicineManager.Find(name[i]);
            //        Stock aStock = new Stock();
            //        aStock.MedicineId = aMedicine.Id;
            //        aStock.CenterId = Convert.ToInt32(centerDropDownList.SelectedValue);
            //        aStock.Quantity = Convert.ToInt32(quantity[i]);
            //        aStock.DistrictId = Convert.ToInt32(districtDropDownList.SelectedValue);
            //        aStock.ThanaId = Convert.ToInt32(thanaDropDownList.SelectedValue);
            //        msg = aStockManager.AddStockDetails(aStock);


            //    }
            //    messageLabel.Text = msg;
            //}
            //    Treatment aTreatment = new Treatment();
            //    aTreatment.DiseaseId = Convert.ToInt32(diseaseDropDownList.SelectedValue);
            //    aTreatment.DoseId = Convert.ToInt32(doseDropDownList.SelectedValue);
            //    aTreatment.MedicineId = Convert.ToInt32(medicineDropDownList.SelectedValue);
            //    aTreatment.Note = noteTextBox.Text;
            //    aTreatment.Quantity = Convert.ToInt32(quantitygivenTextBox.Text);
            //    if (timeOfMealRadioButtonList.Text=="Before Meal")
            //    {
            //        aTreatment.TimeOfMeal = true;
            //    }
            //    else
            //    {
            //        aTreatment.TimeOfMeal = false;
            //    }
            //    string msg=aTreatmentManager.Save(aTreatment);
            //    msgLabel.Text = msg;
            //}
        }

        protected void showDetailsButton_Click(object sender, EventArgs e)
        {
            string id = voterIdTextBox.Text;
            XmlDocument xml = new XmlDocument();
            String URLString = "http://nerdcastlebd.com/web_service/voterdb/index.php/voters/voter/"+id;
            xml.Load(URLString);
            XmlNode name = xml.SelectSingleNode("xml/voter/name");
            nameTextBox.Text = name.InnerText;
            XmlNode address = xml.SelectSingleNode("xml/voter/address");
            addressTextBox.Text = address.InnerText;
            XmlNode node = xml.SelectSingleNode("xml/voter/date_of_birth");
           DateTime dateOfBirth = Convert.ToDateTime(node.InnerText);
            dateOfBirthTextBox.Text = GetAge(dateOfBirth).ToString();
        }
        public static Int32 GetAge( DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
    }
}