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
   public class DoseDbGateway:DbGateway
    {
       public List<Dose> GetAll()
       {
           string query = "SELECT *FROM tbl_dose";
           ASqlConnection.Open();
           ASqlCommand = new SqlCommand(query, ASqlConnection);
           ASqlDataReader = ASqlCommand.ExecuteReader();
           List<Dose> DoseList = new List<Dose>();
           while (ASqlDataReader.Read())
           {
               Dose aDose =new Dose();
               aDose.Id = Convert.ToInt32(ASqlDataReader["id"]);
               aDose.Time = ASqlDataReader["dose"].ToString();
             
               DoseList.Add(aDose);
           }
           ASqlDataReader.Close();
           ASqlConnection.Close();
           return DoseList;
       }
       public Dose Find(string name)
       {
           string query = "Select * from tbl_dose where dose='" + name + "';";
           ASqlConnection.Open();
           ASqlCommand = new SqlCommand(query, ASqlConnection);
           ASqlDataReader = ASqlCommand.ExecuteReader();

           int service = 0;
           Dose aDose = new Dose();
           while (ASqlDataReader.Read())
           {

               aDose.Id = (int)ASqlDataReader["id"];
               aDose.Time = ASqlDataReader["time"].ToString();

           }
           ASqlDataReader.Close();
           ASqlConnection.Close();

           return aDose;
       }
    }
}
