using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemoForFactory.Models;
using WebApiDemoForFactory.Models.DbContexts;

namespace WebApiDemoForFactory.Repositories
{
    public class PersonDataRepository : IPersonDataRepository
    {
        private readonly PeopleDbContext _context;

        public PersonDataRepository(PeopleDbContext ctx)
        {
            _context = ctx;
        }
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
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person;
        }
    }
}
