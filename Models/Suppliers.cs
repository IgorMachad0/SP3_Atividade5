using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPets_MVC_SP5.Models
{
    public class Supplier
    {
        public int Id {get; set; }
        public string? Name { get; set; }
        public int EN { get; set; }
        public string? Email { get; set; }

        public Supplier(int id, string name, int en, string email)
        {
            
            this.Id = id;
            this.Name = name;
            this.EN = en;
            this.Email = email;
        }
    }
}