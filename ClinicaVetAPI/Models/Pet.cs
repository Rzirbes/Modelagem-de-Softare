using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVetAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Especie { get; set; }

        public string? Raca { get; set; }

        public int? TutorId { get; set; }
        public Tutor? Tutor { get; set; }




    }
}