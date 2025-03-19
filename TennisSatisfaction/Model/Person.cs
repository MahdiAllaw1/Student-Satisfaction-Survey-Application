using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSatisfaction.Model
{
    public abstract class Person
    {
        private string name;

        [Required]
        public string Name { get { return name; } } 

        public Person(string name)
        {
            this.name = name;
        }
    }
}
