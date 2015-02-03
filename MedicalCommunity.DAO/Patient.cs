using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunity.DAO
{
   public class Patient
    { 
       public int Id { set; get; }
       public string Name { set; get; }
      public int DiseaseId { set; get; }
      public int DistrictId { set; get; }
      public int ThanaId { set; get; }
      public int TreatmeantId { set; get; }
      public int CenterId { set; get; }
     
    }
}
