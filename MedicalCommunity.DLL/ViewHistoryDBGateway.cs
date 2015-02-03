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
    public class ViewHistoryDBGateway:DbGateway
    {
        public List<ViewHistory> ViewStory(string name)
        {

            DiseaseDbGateway aDiseaseDbGateway =new DiseaseDbGateway();
            DistrictDbGateway aDistrictDbGateway =new DistrictDbGateway();
            ThanaDbGateway aThanaDbGateway =new ThanaDbGateway();
            CenterDbGateway aCenterDbGateway = new CenterDbGateway();
            string query = "SELECT *FROM tbl_patient WHERE name='"+name+"'";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            List<ViewHistory> viewHistories = new List<ViewHistory>();
            while (ASqlDataReader.Read())
            {
                ViewHistory aViewHistory=new ViewHistory();
                aViewHistory.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aViewHistory.Name = ASqlDataReader["name"].ToString();
                aViewHistory.Diseases = aDiseaseDbGateway.Find(Convert.ToInt32(ASqlDataReader["diseaseId"])).Name;
                aViewHistory.Destrict =aDistrictDbGateway.Find(Convert.ToInt32(ASqlDataReader["districtId"])).Name;
              
                aViewHistory.Thana= aThanaDbGateway.Find(Convert.ToInt32(ASqlDataReader["thanaId"])).Name;
                aViewHistory.Center = aCenterDbGateway.Search(Convert.ToInt32(ASqlDataReader["centerId"])).Name;
                
                viewHistories.Add(aViewHistory);
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return viewHistories;
        } 
    }
}
