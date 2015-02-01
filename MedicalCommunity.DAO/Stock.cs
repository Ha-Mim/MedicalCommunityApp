using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunityAutomation.DAO
{
    public class Stock
    {
        public int Id { set; get; }
        public string MedicineName { set; get; }
        public int Quantity { set; get; }
        public int DistrictId { set; get; }
        public int ThanaId { set; get; }
        public int CenterId { set; get; }
        public int MedicineId { set; get; }

    }
}
