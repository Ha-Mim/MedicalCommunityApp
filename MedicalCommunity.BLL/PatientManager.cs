using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;

namespace MedicalCommunity.BLL
{
   public class PatientManager
    {
       PatientDbGateway aPatientDbGateway=new PatientDbGateway();

       public Patient Search(string name)
       {
           return aPatientDbGateway.Search(name);
       }

    }
}
