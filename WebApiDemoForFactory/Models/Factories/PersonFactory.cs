using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemoForFactory.Models.Factories
{
    public class PersonFactory : IPersonFactory
    {
        public Person CreatePersonObject()
        {
            return new Person();
        }

        public Person CreatePersonObjectWithParams(int? id, string name, string surname, string address, DateTime? birthDate, int heightInCm)
        {
            return new Person()
            {
                Id = id,
                Address = address,
                Name = name,
                Surname = surname,
                BirthDate = birthDate,
                HeightInCm = heightInCm
            };
        }
    }
}
