using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.BLL
{
    public class DiseaseManager
    {
        DiseaseDbGateway aDiseaseDbGateway =new DiseaseDbGateway();

        public string SaveDisease(Disease aDisease)
        {
            aDiseaseDbGateway.SaveDisease(aDisease);
            return "Successfully Saved";
        }

        public List<Disease> GetAll()
        {
            return aDiseaseDbGateway.GetAll();
        }

        public int Find(string name)
        {
            return aDiseaseDbGateway.Find(name);
        }
    }
}
