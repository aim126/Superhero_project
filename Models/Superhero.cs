using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroesProject.Models
{
    public class Superhero
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}
