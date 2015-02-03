using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunity.DAO
{
    public class Medicine
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string MgMl { set; get; }
        public override string ToString()
        {
            return Name + " , " + MgMl ;
        }
    }
}
