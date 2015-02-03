using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MedicalCommunity.DAO;
using MedicalCommunityAutomation.DAL;

namespace MedicalCommunity.DLL
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

        public List<Disease> GetAll()
        {
            List<Disease> diseaseList = new List<Disease>();
            string query = "SELECT *FROM tbl_disease";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            while (ASqlDataReader.Read())
            {
                Disease aDisease = new Disease();
                aDisease.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aDisease.Name = ASqlDataReader["name"].ToString();
                aDisease.Description = ASqlDataReader["description"].ToString();
                aDisease.TreatmentProcedure = ASqlDataReader["treatment_procedure"].ToString();
                aDisease.PreferedDrugs = ASqlDataReader["prefered_drugs"].ToString();
                diseaseList.Add(aDisease);
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return diseaseList;
        }

        public int Find(string name)
        {
            
            string query = "SELECT *FROM tbl_disease where name='"+name+"';";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Disease aDisease = new Disease();
            while (ASqlDataReader.Read())
            {
                
                aDisease.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aDisease.Name = ASqlDataReader["name"].ToString();
                aDisease.Description = ASqlDataReader["description"].ToString();
                aDisease.TreatmentProcedure = ASqlDataReader["treatment_procedure"].ToString();
                aDisease.PreferedDrugs = ASqlDataReader["prefered_drugs"].ToString();
                
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return aDisease.Id;
        }
        public Disease Find(int id)
        {
            Disease aDisease = new Disease();
            string query = "SELECT *FROM tbl_disease WHERE id = '" + id + "'";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            while (ASqlDataReader.Read())
            {

                aDisease.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aDisease.Name = ASqlDataReader["name"].ToString();

            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return aDisease;
        }
    }
}
