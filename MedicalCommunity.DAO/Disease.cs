namespace MedicalCommunity.DAO
{
    public class Disease
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string TreatmentProcedure { set; get; }
        public string PreferedDrugs { set; get; }
        public override string ToString()
        {
            return Name;
        }

    }
}
