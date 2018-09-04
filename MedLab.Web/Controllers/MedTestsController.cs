using MedLab.Business;
using MedLab.Core.Interfaces;
using MedLab.Data.Sql.Repositories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MedLab.Web.Controllers
{
    public class MedTestsController : Controller
    {
        private readonly IMedTestService _medTestService;

        public MedTestsController(IMedTestService medTestService)
        {
            _medTestService = medTestService;
        }

        // GET: MedTests
        public async Task<ActionResult> Index()
        {
            var medTests = await _medTestService.GetTestsAsync();

            return View(medTests);
        }
    }
}