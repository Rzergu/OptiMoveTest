using GlobalETestLV.Core.Entities;

namespace GlobalETestLV.ViewModels
{
    public class TimerViewModel
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public int TemplateId { get; set; }
        public int FilterId { get; set; }
        public byte Priority { get; set; }
    }
}
