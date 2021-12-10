using System.Collections.Generic;
using WebApiDemoForFactory.Models;

namespace WebApiDemoForFactory.Repositories
{
    public interface IPersonDataRepository
    {
        public List<Person> GetObjects();
        public Person GetObject(int objectId);
        public Person UpdatePerson(Person person);
        public Person SavePerson(Person person);
    }
}