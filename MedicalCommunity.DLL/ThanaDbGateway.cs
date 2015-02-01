using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.DAL
{
   public class ThanaDbGateway : DbGateway
    {
       public List<Thana> GetThanasByDistrictId(int districtId)
       {
           string query = "SELECT *FROM tbl_thana WHERE district_id='" + districtId + "' ";
           ASqlConnection.Open();
           ASqlCommand = new SqlCommand(query, ASqlConnection);
           ASqlDataReader = ASqlCommand.ExecuteReader();

           List<Thana> thanaList = new List<Thana>();

           while (ASqlDataReader.Read())
           {

               Thana aThana = new Thana();
               aThana.Id = (int)ASqlDataReader["id"];
               aThana.Name = ASqlDataReader["name"].ToString();
               aThana.DistrictId = Convert.ToInt32(ASqlDataReader["district_id"]);

               thanaList.Add(aThana);
           }
           ASqlDataReader.Close();
           ASqlConnection.Close();

           return thanaList;
       }
    }
}
