using System;
using System.Collections.Generic;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunity.BLL
{
    public class DoctorManager
    {
        DoctorDbGateway aDoctorDbGateway = new DoctorDbGateway();

        public string Save(Doctor aDoctor)
        {
            aDoctorDbGateway.Save(aDoctor);
            return "Successfully Saved";
        }

        public List<Doctor> GetAll(int centerId)
        {
            return aDoctorDbGateway.GetAll(centerId);
        }
    }
}
