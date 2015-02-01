using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunityAutomation.DAO
{
    public class Center
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int DistrictId { set; get; }
        public int ThanaId { set; get; }
        public string Code { set; get; }
        public string Password { set; get; }


        public string CreateCode()
        {
            string name = Name.Replace(" ", "");
            string codeForCenter = name.Substring(0, 5);
            return codeForCenter.ToLower() + DistrictId + ThanaId;
        }

        public string CreatePassword()
        {
            string name = Name.Replace(" ", "");
            return name.ToLower();
        }
    }
}
