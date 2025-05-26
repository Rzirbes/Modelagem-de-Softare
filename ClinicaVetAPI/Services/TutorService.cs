using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVetAPI.Interfaces;
using ClinicaVetAPI.Interfaces.Repositories;
using ClinicaVetAPI.Models;

namespace ClinicaVetAPI.Services
{
    public class TutorService : IBaseService<Tutor>
    {
        private readonly ITutorRepository _tutorRepository;

        public TutorService(ITutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }

        public async Task<Tutor> Add(Tutor tutor)
        {
            return await _tutorRepository.Add(tutor);
        }

        public async Task<List<Tutor>> GetAll()
        {
            var tutores = await _tutorRepository.GetAll();
            return tutores.ToList();
        }

        public async Task<Tutor?> GetById(int id)
        {
            return await _tutorRepository.GetById(id);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _tutorRepository.Delete(id);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }

        public async Task<Tutor?> Update(int id, Tutor tutor)
        {
            try
            {
                return await _tutorRepository.Update(id, tutor);
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
