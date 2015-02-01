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
    }
}
