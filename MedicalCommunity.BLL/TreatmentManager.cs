using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;

namespace MedicalCommunity.BLL
{
  public  class TreatmentManager
    {
      TreatmentDbGateway aTreatmentDbGateway=new TreatmentDbGateway();
      public string Save(Treatment aTreatment)
      {
          aTreatmentDbGateway.Save(aTreatment);
          return "Saved";
      }

      //public List<Treatment> GetAllDate()
      //{
      //   return aTreatmentDbGateway.GetAllDate();
      //}
    }
}
