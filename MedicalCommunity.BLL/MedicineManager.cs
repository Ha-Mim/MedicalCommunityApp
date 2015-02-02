using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;

namespace MedicalCommunity.BLL
{
    public class MedicineManager
    {
        MedicineDBGateway aMedicineDbGateway = new MedicineDBGateway();
        public string Save(Medicine aMedicine)
        {
            aMedicineDbGateway.Save(aMedicine);
            return "Saved";
        }

        public List<Medicine> GetAllMedicine()
        {
            return aMedicineDbGateway.GetAllMedicine();
        }

     
        public Medicine Find(string name)
        {
            return aMedicineDbGateway.Find(name);
        }
    }
}
