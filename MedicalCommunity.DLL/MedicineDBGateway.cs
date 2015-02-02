using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MedicalCommunity.DAO;
using MedicalCommunityAutomation.DAL;

namespace MedicalCommunity.DLL
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

        public List<Medicine> GetAllMedicine()
        {
            string query = "SELECT *FROM tbl_medicine";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            List<Medicine> aMedicineList = new List<Medicine>();
            while (ASqlDataReader.Read())
            {
                Medicine aMedicine = new Medicine();
                aMedicine.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aMedicine.Name = ASqlDataReader["Name"].ToString();
                aMedicine.MgMl = ASqlDataReader["mg_ml"].ToString();
                aMedicineList.Add(aMedicine);
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return aMedicineList;
        }


        public Medicine Find(int id)
        {
            string query = "SELECT *FROM tbl_medicine where id="+id;
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Medicine aMedicine = new Medicine();
            while (ASqlDataReader.Read())
            {
                
                aMedicine.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aMedicine.Name = ASqlDataReader["Name"].ToString();
                aMedicine.MgMl = ASqlDataReader["mg_ml"].ToString();
                
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return aMedicine;
        }

        public Medicine Find(string name)
        {
            string query = "SELECT *FROM tbl_medicine where Name='" +name+"';" ;
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Medicine aMedicine = new Medicine();
            while (ASqlDataReader.Read())
            {

                aMedicine.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aMedicine.Name = ASqlDataReader["Name"].ToString();
                aMedicine.MgMl = ASqlDataReader["mg_ml"].ToString();

            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return aMedicine;
        }
    }
}
