using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemoForFactory.Models.Validators.Interfaces
{
    public interface IPersonValidator
    {
        public bool IsAddressValid(string address);
        public bool IsIdSet(int? id);
    }
}
