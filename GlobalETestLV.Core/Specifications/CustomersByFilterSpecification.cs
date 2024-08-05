using GlobalETestLV.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalETestLV.Core.Specifications
{
    public class CustomerByFilterSpecification : BaseSpecification<Customer>
    {
        public CustomerByFilterSpecification(TimerFilter filter) 
            : base(b => true)
        {
            ApplyFilter(b => (filter.IsNew == null || b.IsNew == filter.IsNew) 
            && (filter.Cities == null || filter.Cities.Count == 0 || filter.Cities.Contains(b.City))
            && (filter.Genders == null || filter.Genders.Count == 0 || filter.Genders.Contains(b.Gender))
            && filter.DepositFrom <= b.Deposit && b.Deposit <= filter.DepositTo
            && filter.AgeFrom <= b.Age && b.Age <= filter.AgeTo);
        }
    }
}
