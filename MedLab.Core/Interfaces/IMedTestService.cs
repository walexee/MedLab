using System.Collections.Generic;
using System.Threading.Tasks;
using MedLab.Core.Models;

namespace MedLab.Core.Interfaces
{
    public interface IMedTestService
    {
        Task<IList<MedTest>> GetTestsAsync();
    }
}