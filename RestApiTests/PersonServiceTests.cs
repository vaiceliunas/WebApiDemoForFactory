using Moq;
using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApiDemoForFactory.Models;
using WebApiDemoForFactory.Models.Factories;
using WebApiDemoForFactory.Models.Validators;
using WebApiDemoForFactory.Repositories;
using WebApiDemoForFactory.Services;
using WebApiDemoForFactory.Services.Interfaces;
using Xunit;

namespace RestApiTests
{
    public class PersonServiceTests
    {
        private readonly IPersonService _service;
        private readonly Mock<IPersonDataRepository> _serviceRepositoryMock = new();
        private readonly IPersonFactory _personFactory;

        public PersonServiceTests()
        {
            _personFactory = new PersonFactory();
            _service = new PersonService(_serviceRepositoryMock.Object, new PersonValidator(), _personFactory);
        }
        [Fact]
        public void SavePerson_WithNoAddress_ReturnsInvalidModel()
        {
            //Arrange
            var personObj = _personFactory.CreatePersonObjectWithParams(null, "vardas", "pavarde", string.Empty, DateTime.Now, 50);
            var model = new ModelStateDictionary();
            _serviceRepositoryMock.Setup(o => o.SavePerson(personObj)).Returns(personObj);
            //Act
            _service.SavePerson(personObj, model);
            //Assert
            Assert.True(!model.IsValid);
        }

        [Fact]
        public void SavePerson_WithDefinedId_ReturnsInvalidModel()
        {
            //Arrange
            var personObj = _personFactory.CreatePersonObjectWithParams(65, "vardas", "pavarde", "adress", DateTime.Now, 50);
            var model = new ModelStateDictionary();
                        _serviceRepositoryMock.Setup(o => o.SavePerson(personObj)).Returns(personObj);
            //Act
            _service.SavePerson(personObj, model);
            //Assert
            Assert.True(!model.IsValid);
        }

        [Fact]
        public void SavePerson_WithValidParams_ReturnsValidModel()
        {
            //Arrange
            var personObj = _personFactory.CreatePersonObjectWithParams(null, "vardas", "pavarde", "adress", DateTime.Now, 50);
            var model = new ModelStateDictionary();
            _serviceRepositoryMock.Setup(o => o.SavePerson(personObj)).Returns(personObj);
            //Act
            _service.SavePerson(personObj, model);
            //Assert
            Assert.True(model.IsValid);
        }
    }
}
