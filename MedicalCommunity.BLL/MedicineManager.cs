using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DBGateway;

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

        //public object GetAllMedicine()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
