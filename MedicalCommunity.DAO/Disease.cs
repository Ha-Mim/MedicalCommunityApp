using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunityAutomation.DAO
{
    public class Disease
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string TreatmentProcedure { set; get; }
        public string PreferedDrugs { set; get; }

    }
}
