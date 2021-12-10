using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemoForFactory.Models.Factories
{
    public interface IPersonFactory
    {
        public Person CreatePersonObject();
        public Person CreatePersonObjectWithParams(int? id, string name, string surname, string address, DateTime? birthDate, int heightInCm);
    }
}
