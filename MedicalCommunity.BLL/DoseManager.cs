using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;

namespace MedicalCommunity.BLL
{
    public class DoseManager
    {
        DoseDbGateway aDoseDbGateway=new DoseDbGateway();
        public List<Dose> GetAll()
        {
            return aDoseDbGateway.GetAll();
        }
        public Dose Find(string name)
        {
            return aDoseDbGateway.Find(name);
        }
    }
}
