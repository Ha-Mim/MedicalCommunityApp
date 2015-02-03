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
    public class ThanaManager
    {
        ThanaDbGateway aThanaDbGateway=new ThanaDbGateway();
        public List<Thana> GetThanasByDistrictId(int districtId)
        {
            return aThanaDbGateway.GetThanasByDistrictId(districtId);

        }
    }
}
