using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVetAPI.Models
{
    public class Tutor
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }

        public List<Pet> Pets { get; set; } = new List<Pet>();


    }
}