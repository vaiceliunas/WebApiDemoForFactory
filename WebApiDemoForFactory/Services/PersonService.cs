using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApiDemoForFactory.Models;
using WebApiDemoForFactory.Models.Constants;
using WebApiDemoForFactory.Models.Factories;
using WebApiDemoForFactory.Models.Validators.Interfaces;
using WebApiDemoForFactory.Repositories;
using WebApiDemoForFactory.Services.Interfaces;

namespace WebApiDemoForFactory.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDataRepository _personDataRepository;
        private readonly IPersonValidator _personValidator;
        private readonly IPersonFactory _personFactory;

        public PersonService(IPersonDataRepository repository, IPersonValidator validator, IPersonFactory factory)
        {
            _personDataRepository = repository;
            _personValidator = validator;
            _personFactory = factory;
        }
        public List<Person> GetPersons(ModelStateDictionary model)
        {
            return _personDataRepository.GetObjects();
        }

        public Person GetPerson(int objectId, ModelStateDictionary model)
        {
            return _personDataRepository.GetObject(objectId);
        }

        public object UpdatePerson(Person person, ModelStateDictionary model)
        {

            if (_personValidator.IsAddressValid(person.Address))
                model.AddModelError(PropertyNames.PersonAddressProperty, ErrorMessages.InvalidAddressErrorMessage);

            if (model.ErrorCount > 0)
                return _personFactory.CreatePersonObject();

            return _personDataRepository.UpdatePerson(person);
        }

        public Person SavePerson(Person person, ModelStateDictionary model)
        {
            if(!_personValidator.IsAddressValid(person.Address))
                model.AddModelError(PropertyNames.PersonAddressProperty, ErrorMessages.InvalidAddressErrorMessage);
            if(_personValidator.IsIdSet(person.Id))
                model.AddModelError(PropertyNames.IdProperty, ErrorMessages.IdSetErrorMessage);

            return model.ErrorCount > 0 ? _personFactory.CreatePersonObject() : _personDataRepository.SavePerson(person);
        }
    }
}
