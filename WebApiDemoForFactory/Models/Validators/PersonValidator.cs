using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemoForFactory.Models.Validators.Interfaces;

namespace WebApiDemoForFactory.Models.Validators
{
    public class PersonValidator : IPersonValidator
    {
        public bool IsAddressValid(string address)
        {
            return !string.IsNullOrEmpty(address);
        }

        public bool IsIdSet(int? id)
        {
            return id.HasValue;
        }
    }
}
