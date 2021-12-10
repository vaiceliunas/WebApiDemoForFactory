using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemoForFactory.Models
{
    public class Person
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public int HeightInCm { get; set; }
    }
}
