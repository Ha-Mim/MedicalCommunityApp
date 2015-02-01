using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunityAutomation.DAL;

namespace MedicalCommunity.DBGateway
{
    public class MedicineDBGateway:DbGateway
    {
        public void Save(Medicine aMedicine)
        {
            string query = "INSERT INTO tbl_medicine VALUES('" + aMedicine.Name + "','" + aMedicine.MgMl + "')";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlCommand.ExecuteNonQuery();
            ASqlConnection.Close();
        }
    }
}
