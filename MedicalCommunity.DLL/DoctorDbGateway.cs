using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.DAL
{
    public class DoctorDbGateway :DbGateway
    {
        public void Save(Doctor aDoctor)
        {
            string query = "INSERT INTO tbl_doctor VALUES('" + aDoctor.Name + "' , '" + aDoctor.Degree + "','"+aDoctor.Specialization+"','"+aDoctor.CenterId+"')";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlCommand.ExecuteNonQuery();
            ASqlConnection.Close();
        }

        public List<Doctor> GetAll(int centerId)
        {
            List<Doctor> adoctorList = new List<Doctor>();
            string query = "SELECT *FROM tbl_doctor where centerId="+centerId;
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            while (ASqlDataReader.Read())
            {
                Doctor aDoctor = new Doctor();
                aDoctor.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aDoctor.Name = ASqlDataReader["name"].ToString();
                aDoctor.Degree = ASqlDataReader["degree"].ToString();
                aDoctor.Specialization = ASqlDataReader["specialization"].ToString();
                adoctorList.Add(aDoctor);
            }
            ASqlDataReader.Close();
            ASqlConnection.Close();
            return adoctorList;
        }
    }
}
