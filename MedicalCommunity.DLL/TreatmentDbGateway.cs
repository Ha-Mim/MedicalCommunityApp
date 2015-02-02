using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunityAutomation.DAL;

namespace MedicalCommunity.DLL
{
   public class TreatmentDbGateway:DbGateway
    {
       public void Save(Treatment aTreatment)
       {
           string query = "INSERT INTO tbl_treatment VALUES('" + aTreatment.DiseaseId + "' , '" + aTreatment.MedicineId + "','" + aTreatment.DoseId + "','" + aTreatment.TimeOfMeal + "','"+aTreatment.Quantity+"','"+aTreatment.Note+"')";
           ASqlConnection.Open();
           ASqlCommand = new SqlCommand(query, ASqlConnection);
           ASqlCommand.ExecuteNonQuery();
           ASqlConnection.Close();
       }

       //public List<Treatment> GetAllDate()
       //{

       //}
    }
}
