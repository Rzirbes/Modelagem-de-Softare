using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClinicaVetAPI.DTO;
using ClinicaVetAPI.Models;

namespace ClinicaVetAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TutorDTO, Tutor>();
            CreateMap<Tutor, TutorDTO>();

            CreateMap<PetDTO, Pet>();
            CreateMap<Pet, PetDTO>();
        }
    }
}