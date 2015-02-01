using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.BLL
{
    public class DoctorManager
    {
        DoctorDbGateway aDoctorDbGateway = new DoctorDbGateway();

        public string Save(Doctor aDoctor)
        {
            aDoctorDbGateway.Save(aDoctor);
            return "Successfully Saved";
        }
    }
}
