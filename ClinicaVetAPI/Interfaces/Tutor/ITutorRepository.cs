using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVetAPI.Models;

namespace ClinicaVetAPI.Interfaces.Repositories
{
    public interface ITutorRepository
    {
        Task<IEnumerable<Tutor>> GetAll();
        Task<Tutor?> GetById(int id);
        Task<Tutor> Add(Tutor tutor);
        Task<Tutor> Update(int id, Tutor tutor);
        Task Delete(int id);
    }
}