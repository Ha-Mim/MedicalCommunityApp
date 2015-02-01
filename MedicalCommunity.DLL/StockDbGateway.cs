using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DBGateway;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.DAL
{
   public class StockDbGateway:DbGateway
    {

        public List<Stock> GetAll(int centerId)
        {
            string query = "SELECT *FROM tbl_stock where centerId=" + centerId;
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();

            List<Stock> stockList = new List<Stock>();

            while (ASqlDataReader.Read())
            {
                MedicineDBGateway aGateway = new MedicineDBGateway();;
                Stock aStock = new Stock();
                Medicine aMedicine = aGateway.Find(Convert.ToInt32(ASqlDataReader["id"]));
                aStock.MedicineName = aMedicine.Name + "_" + aMedicine.MgMl;
                aStock.Quantity = (int) ASqlDataReader["quantity"];
                
                stockList.Add(aStock);
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();

            return stockList;
        }


       public void AddInventoryDetails(Stock aStock)
       {
           string query = "INSERT INTO tbl_stock VALUES('" + aStock.DistrictId + "','" + aStock.ThanaId + "','" + aStock.CenterId + "','" + aStock.MedicineId + "','" + aStock.Quantity + "')";
           ASqlConnection.Open();
           ASqlCommand = new SqlCommand(query, ASqlConnection);
           ASqlCommand.ExecuteNonQuery();
           ASqlConnection.Close();
       }
    }
}
