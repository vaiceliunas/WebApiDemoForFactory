using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemoForFactory.Models.Entities
{
    public class StdProperty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
