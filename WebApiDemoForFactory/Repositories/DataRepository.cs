using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemoForFactory.Models;

namespace WebApiDemoForFactory.Repositories
{
    public class PersonDataRepository : IPersonDataRepository
    {
        public List<Person> GetObjects()
        {
            return new List<Person>();
        }

        public Person GetObject(int objectId)
        {
            //traukimas is db
            return new Person();
        }

        public Person UpdatePerson(Person person)
        {
            //iraso atnaujinimas
            return person;
        }

        public Person SavePerson(Person person)
        {
            //saugojimas I DB
            return person;
        }
    }
}
