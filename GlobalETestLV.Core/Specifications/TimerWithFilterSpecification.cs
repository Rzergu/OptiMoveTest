using GlobalETestLV.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalETestLV.Core.Specifications
{
    public class TimerWithFilterSpecification : BaseSpecification<TimerItem>
    {
        public TimerWithFilterSpecification()
            : base(b => true)
        {
            AddInclude(x => x.Filter);
        }
    }
}
