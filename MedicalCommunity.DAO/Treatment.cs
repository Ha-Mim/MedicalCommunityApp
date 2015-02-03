using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCommunity.DAO
{
    public class Treatment
    {
        public int Id { set; get; }
        public int DiseaseId { set; get; }
        public int MedicineId { set; get; }
        public int DoseId { set; get; }
        public bool TimeOfMeal { set; get; }
        public int Quantity { set; get; }
        public string Note { set; get; }
        public DateTime Date { set; get; }
        public int PatientId { set; get; }
    }
}
