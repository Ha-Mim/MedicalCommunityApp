using System;
using MedicalCommunity.BLL;
using MedicalCommunity.DAO;

namespace MedicalCommunityAutomation
{
    public partial class SetupMedicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        MedicineManager aMedicineManager=new MedicineManager();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Medicine aMedicine=new Medicine();
            aMedicine.Name = genericNameTextBox.Text;
            aMedicine.MgMl = quantityTextBox.Text;
            string msg = aMedicineManager.Save(aMedicine);
            msgLabel.Text = msg;
        }
    }
}