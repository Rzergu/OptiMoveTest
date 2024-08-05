using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalETestLV.Core.Entities
{
    public class SendedRow
    {
        public int Id {  get; set; }
        public DateTime SendTime { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TemplateId { get; set; }
        public Template Template { get; set; }
    }
}
