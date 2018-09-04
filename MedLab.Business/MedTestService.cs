using MedLab.Core.Interfaces;
using MedLab.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedLab.Business
{
    public class MedTestService : IMedTestService
    {
        private readonly IMedTestRepository _medTestRepository;

        public MedTestService(IMedTestRepository medTestRepository)
        {
            _medTestRepository = medTestRepository;
        }

        public Task<MedTest> GetTestAsync(int id)
        {
            return _medTestRepository.GetAsync(id);
        }

        public Task<IList<MedTest>> GetTestsAsync()
        {
            return _medTestRepository.GetAllAsync();
        }

        public async Task SaveTestAsync(MedTest medTest)
        {
            if (medTest.Id == 0)
            {
                medTest.Created = DateTime.UtcNow;
                medTest.CreatedById = "d86d70f6-6636-4300-986a-cce32a105134";

                await _medTestRepository.AddAsync(medTest);

                return;
            }

            var dbMedTest = await _medTestRepository.GetAsync(medTest.Id);

            dbMedTest.Name = medTest.Name;
            dbMedTest.Description = medTest.Description;
            dbMedTest.Amount = medTest.Amount;

            await _medTestRepository.UpdateAsync(dbMedTest);
        }

        public Task DeleteTestAsync(int id)
        {
            return _medTestRepository.DeleteAsync(id);
        }
    }
}
