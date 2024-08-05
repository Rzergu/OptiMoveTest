using GlobalETestLV.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalETestLV.Core.Specifications
{
    public class SameTimeTimersSpecification : BaseSpecification<TimerItem>
    {
        public SameTimeTimersSpecification(TimeOnly time) : base(b => b.Time == time)
        {

        }
    }
}
