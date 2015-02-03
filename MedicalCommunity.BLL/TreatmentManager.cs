using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;
using MedicalCommunityAutomation.DAL;

namespace MedicalCommunity.BLL
{
  public  class TreatmentManager
    {
      StockDbGateway aStockDbGateway=new StockDbGateway();
      TreatmentDbGateway aTreatmentDbGateway=new TreatmentDbGateway();
      public string Save(Treatment aTreatment)
      {
          aStockDbGateway.Update(aTreatment.CenterId, aTreatment.MedicineId, aTreatment.Quantity);
          aTreatmentDbGateway.Save(aTreatment);
          return "Saved";
      }

    
      public int Count(int patientId)
      {
          return aTreatmentDbGateway.Count(patientId);
      }

      
    }
}
