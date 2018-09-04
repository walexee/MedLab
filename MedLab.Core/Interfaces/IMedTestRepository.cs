using System.Collections.Generic;
using System.Threading.Tasks;
using MedLab.Core.Models;

namespace MedLab.Core.Interfaces
{
    public interface IMedTestRepository
    {
        Task<int> AddAsync(MedTest medTest);
        Task<IList<MedTest>> GetAllAsync();
        Task<MedTest> GetAsync(int medTestId);
    }
}