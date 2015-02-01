using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.DAL
{
    public class DiseaseDbGateway:DbGateway
    {

        public void SaveDisease(Disease aDisease)
        {
            string query = "INSERT INTO tbl_disease VALUES('" + aDisease.Name + "' , '" + aDisease.Description + "','" + aDisease.TreatmentProcedure + "','" + aDisease.PreferedDrugs + "')";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlCommand.ExecuteNonQuery();
            ASqlConnection.Close();
            
        }
    }
}
