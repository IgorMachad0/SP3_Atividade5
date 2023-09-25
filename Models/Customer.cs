using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPets_MVC_SP5.Models
{
    public class Customer
    {
        public int Id {get; set; }
        public string? Name { get; set; }
        public int ITIN { get; set; }
        public string? Email { get; set; }
        public string? Patient { get; set; }

        public Customer(int id, string name, int itin, string email, string patient)
        {
            
            this.Id = id;
            this.Name = name;
            this.ITIN = itin;
            this.Email = email;
            this.Patient = patient;
        }
    }
}