using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
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
        PatientManager aPatientManager=new PatientManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                int centerId = Convert.ToInt32(Session["id"]);
                doctorDropDownList.DataSource = aDoctorManager.GetAll(centerId);
                doctorDropDownList.DataTextField = "Name";
                doctorDropDownList.DataValueField = "Id";
                doctorDropDownList.DataBind();

                diseaseDropDownList.DataSource = aDiseaseManager.GetAll();
                
                diseaseDropDownList.DataBind();

                medicineDropDownList.DataSource = aMedicineManager.GetAllMedicine();
                
                medicineDropDownList.DataBind();

                doseDropDownList.DataSource = aDoseManager.GetAll();
              
                doseDropDownList.DataBind();

            }
        }

      

        protected void showDetailsButton_Click(object sender, EventArgs e)
        {
            string id = voterIdTextBox.Text;
            Session["id"] = id;
            XmlDocument xml = new XmlDocument();
            String URLString = "http://nerdcastlebd.com/web_service/voterdb/index.php/voters/voter/"+id;
            xml.Load(URLString);
            XmlNode name = xml.SelectSingleNode("xml/voter/name");
            nameTextBox.Text = name.InnerText;
            Session["name"] = nameTextBox.Text;
            XmlNode address = xml.SelectSingleNode("xml/voter/address");
            addressTextBox.Text = address.InnerText;
            Session["address"] = addressTextBox.Text;
            XmlNode node = xml.SelectSingleNode("xml/voter/date_of_birth");
            DateTime dateOfBirth = Convert.ToDateTime(node.InnerText);
            ageTextBox.Text = GetAge(dateOfBirth).ToString();
            Treatment aTreatment = new Treatment();
            string patientName = nameTextBox.Text;
            aTreatment.PatientId = aPatientManager.Search(patientName).Id;
            serviceGivenTextBox.Text = aTreatmentManager.Count(aTreatment.PatientId).ToString();

        }
        public static Int32 GetAge( DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
             string msg = "";

            var diseaseList = diseaseName.Value;
            diseaseName.Value = "";
            string[] disease = diseaseList.Split(',');

            var mediceneList = medicineName.Value;
            medicineName.Value = "";
            string[] medicine = mediceneList.Split(',');

            var doseList = doseName.Value;
            doseName.Value = "";
            string[] dose = doseList.Split(',');

            var timeOfMealList = timeOfMealName.Value;
            timeOfMealName.Value = "";
            string[] timeOfMeal = timeOfMealList.Split(',');

            var quantityList = quantityName.Value;
            quantityName.Value = "";
            string[] quantityValue = quantityList.Split(',');
         

            var noteList = noteName.Value;
            noteName.Value = "";
            string[] note = noteList.Split(',');

            for (int i = 0; i < disease.Length-1  ; i++)
            {
                Treatment aTreatment = new Treatment();
                string name = nameTextBox.Text;
                aTreatment.PatientId = aPatientManager.Search(name).Id;
                aTreatment.DiseaseId = aDiseaseManager.Find(disease[i]).Id;
                aTreatment.DoseId = aDoseManager.Find(dose[i]).Id;
                aTreatment.MedicineId = aMedicineManager.Find(medicine[i]).Id;
                aTreatment.Note = note[i];
                aTreatment.Date = dateCalendar.SelectedDate;
                aTreatment.Quantity = Convert.ToInt32(quantityValue[i]);
                aTreatment.CenterId = Convert.ToInt32(Session["id"]);
                if (timeOfMealRadioButtonList.Text == "Before Meal")
                {
                    aTreatment.TimeOfMeal = true;
                }
                else
                {
                    aTreatment.TimeOfMeal = false;
                }
                msg = aTreatmentManager.Save(aTreatment);
            }
            msgLabel.Text = msg;
        }

        protected void printButton_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Pescription.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            print.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}