using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalCommunity.BLL;
using MedicalCommunity.DAO;
using MedicalCommunityAutomation.BLL;
using MedicalCommunityAutomation.DAO;

namespace CommunityMedicine.UI
{
    public partial class SendMedicine : System.Web.UI.Page
    {
        CenterManager aCenterManager = new CenterManager();
        MedicineManager aMedicineManager = new MedicineManager();
        StockManager aStockManager = new StockManager();
        DistrictManager aDistrictManager = new DistrictManager();
        ThanaManager aThanaManager = new ThanaManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                districtDropDownList.DataSource = aDistrictManager.GetAll();
                districtDropDownList.DataTextField = "Name";
                districtDropDownList.DataValueField = "Id";
                districtDropDownList.DataBind();

                medicineDropDownList.DataSource = aMedicineManager.GetAllMedicine();
                
                medicineDropDownList.DataBind();
            }
        }

        protected void districtDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            thanaDropDownList.Items.Clear();
            int id = Convert.ToInt32(districtDropDownList.SelectedValue);
            List<Thana> aThanaList = aThanaManager.GetThanasByDistrictId(id); 
            thanaDropDownList.DataSource = aThanaList;
            foreach (Thana aThana in aThanaList)
            {
                thanaDropDownList.DataTextField = "Name";
                thanaDropDownList.DataValueField = "Id";
            }
            thanaDropDownList.DataBind();
        }

        protected void thanaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(thanaDropDownList.SelectedValue);
            List<Center> aCenterList = aCenterManager.GetAllCenterByThanaId(id);
            centerDropDownList.DataSource = aCenterList;
          
            centerDropDownList.DataTextField = "Name";
            centerDropDownList.DataValueField = "Id";
            

            centerDropDownList.DataBind();
        }


        protected void saveButton_Click(object sender, EventArgs e)
        {
            string msg = "";

            var nameList = medicineName.Value;
            medicineName.Value = "";
            string[] name = nameList.Split(',');

            var quantityList = medicineQuantity.Value;
            medicineQuantity.Value = "";
            string[] quantity = quantityList.Split(',');

            for (int i = 0; i < name.Length - 1; i++)
            {
                Medicine aMedicine = aMedicineManager.Find(name[i]);
                Stock aStock = new Stock();
                aStock.MedicineId = aMedicine.Id;
                aStock.CenterId = Convert.ToInt32(centerDropDownList.SelectedValue);
                aStock.Quantity = Convert.ToInt32(quantity[i]);
                aStock.DistrictId = Convert.ToInt32(districtDropDownList.SelectedValue);
                aStock.ThanaId = Convert.ToInt32(thanaDropDownList.SelectedValue);
                msg = aStockManager.AddStockDetails(aStock);


            }
            messageLabel.Text = msg;
        }
    }
}