using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunity.DAO
{
    public class Dose
    {
        public int Id { set; get; }
        public string Time { set; get; }
        public override string ToString()
        {
            return Time;
        }
    }
}
