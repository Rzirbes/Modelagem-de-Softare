using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVetAPI.Models;

namespace ClinicaVetAPI.Interfaces.Repositories
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> GetAll();
        Task<Pet?> GetById(int id);
        Task<Pet> Add(Pet pet);
        Task<Pet> Update(int id, Pet pet);
        Task Delete(int id);
    }
}
