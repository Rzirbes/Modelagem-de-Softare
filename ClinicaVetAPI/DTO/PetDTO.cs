using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVetAPI.DTO
{
    public class PetDTO
    {
        public string? Name { get; set; }
        public string? Especie { get; set; }
        public string? Raca { get; set; }
        public int TutorId { get; set; }
    }
}