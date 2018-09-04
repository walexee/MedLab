using System.Collections.Generic;
using System.Threading.Tasks;
using MedLab.Core.Models;

namespace MedLab.Core.Interfaces
{
    public interface IMedTestService
    {
        Task<MedTest> GetTestAsync(int id);

        Task<IList<MedTest>> GetTestsAsync();

        Task SaveTestAsync(MedTest medTest);

        Task DeleteTestAsync(int id);
    }
}