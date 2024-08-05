namespace GlobalETestLV.ViewModels
{
    public class FilterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Genders { get; set; }
        public List<string> Cities { get; set; }
        public int DepositFrom { get; set; }
        public int DepositTo { get; set; }
        public int AgeFrom { get; set; }

        public int AgeTo { get; set; }

        public bool? IsNew { get; set; }
    }
}
