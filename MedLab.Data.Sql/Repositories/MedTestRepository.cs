using MedLab.Core.Interfaces;
using MedLab.Core.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MedLab.Data.Sql.Repositories
{
    public class MedTestRepository : IMedTestRepository
    {
        private readonly MedLabContext _dbContext;

        public MedTestRepository(MedLabContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddAsync(MedTest medTest)
        {
            _dbContext.MedTests.Add(medTest);

            await _dbContext.SaveChangesAsync();

            return medTest.Id;
        }

        public Task<MedTest> GetAsync(int medTestId)
        {
            return _dbContext.MedTests.FindAsync(medTestId);
        }

        public async Task<IList<MedTest>> GetAllAsync()
        {
            return await _dbContext.MedTests.ToListAsync();
        }
    }
}
