using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApiDemoForFactory.Models;

namespace WebApiDemoForFactory.Services.Interfaces
{
    public interface IPersonService
    {
        public List<Person> GetPersons(ModelStateDictionary model);
        public Person GetPerson(int objectId, ModelStateDictionary model);
        public object UpdatePerson(Person person, ModelStateDictionary model);
        public Person SavePerson(Person person, ModelStateDictionary model);
    }
}
