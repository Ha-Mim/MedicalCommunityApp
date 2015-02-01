using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.BLL
{
    public class CenterManager
    {
        CenterDbGateway aCenterDbGateway = new CenterDbGateway();
        public string SaveCenter(Center aCenter)
        {
            aCenterDbGateway.SaveCenter(aCenter);
            return "Successfully Saved";
        }

        public int Find(string code, string password)
        {
            return aCenterDbGateway.Find(code, password);
        }

    }
}
