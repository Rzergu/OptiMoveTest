using System;
namespace GlobalETestLV.Core.Entities
{
	public class Customer
	{
		public int Id { get; set; }
		public byte Age { get; set; }
		public string? Gender { get; set; }
		public string? City { get; set; }
		public int Deposit { get; set; }
		public bool IsNew { get; set; }

		public int? TimerItemId { get; set; }
		public TimerItem TimerItem { get; set; }


    }
}

