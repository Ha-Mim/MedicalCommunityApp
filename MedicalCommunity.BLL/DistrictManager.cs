using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DLL;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.BLL
{
    public class DistrictManager
    {
        DistrictDbGateway aDistrictDbGateway = new DistrictDbGateway();

        public List<District> GetAll()
        {
            return aDistrictDbGateway.GetAll();
        }
    }
}
