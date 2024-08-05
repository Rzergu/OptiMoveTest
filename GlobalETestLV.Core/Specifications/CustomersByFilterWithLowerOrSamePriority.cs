using GlobalETestLV.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalETestLV.Core.Specifications
{
    public class CustomersByFilterWithLowerOrSamePriority : BaseSpecification<Customer>
    {
        public CustomersByFilterWithLowerOrSamePriority(TimerFilter filter, int priority)
            : base(b => true)
                {
                    AddInclude(c => c.TimerItem);
                    ApplyFilter(b => (filter.IsNew == null || b.IsNew == filter.IsNew)
                    && (filter.Cities == null || filter.Cities.Count == 0 || filter.Cities.Contains(b.City))
                    && (filter.Genders == null || filter.Genders.Count == 0 || filter.Genders.Contains(b.Gender))
                    && (filter.DepositFrom <= b.Deposit && b.Deposit <= filter.DepositTo)
                    && (filter.AgeFrom <= b.Age && b.Age <= filter.AgeTo)
                    && (b.TimerItemId == null || b.TimerItem.Priority >= priority));
                }
    }
}
