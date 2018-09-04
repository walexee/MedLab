using MedLab.Core.Interfaces;
using MedLab.Core.Models;
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

        public Task<IList<MedTest>> GetTestsAsync()
        {
            return _medTestRepository.GetAllAsync();
        }
    }
}
