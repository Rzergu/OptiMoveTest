using System;
namespace GlobalETestLV.Core.Entities
{
	public class TimerItem
	{
		public int Id { get; set; }
		public TimeOnly Time { get; set; }
		public int TemplateId { get; set; }
		public Template Template { get; set; }
		public TimerFilter Filter { get; set; }
		public byte Priority { get; set; }

		public List<Customer> Customers { get; set; }
    }
}


