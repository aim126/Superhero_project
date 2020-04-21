using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroesProject.Models
{
    public class Person
    {
        [key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}
