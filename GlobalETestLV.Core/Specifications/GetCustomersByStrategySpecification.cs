using GlobalETestLV.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalETestLV.Core.Specifications
{
    public class GetCustomersByStrategySpecification : BaseSpecification<Customer>
    {
        public GetCustomersByStrategySpecification(int timerId) : base(b => b.TimerItemId == timerId)
        {
            
        }
    }
}
