using MedLab.Core.Interfaces;
using MedLab.Core.Models;
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

        [HttpGet]
        public async Task<ActionResult> SaveTest(int id = 0)
        {
            var test = new MedTest();

            if (id > 0)
            {
                test = await _medTestService.GetTestAsync(id);
            }

            return View(test);
        }

        [HttpPost]
        public async Task<ActionResult> SaveTest(MedTest medTest)
        {
            await _medTestService.SaveTestAsync(medTest);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public Task DeleteTest(int id)
        {
            return _medTestService.DeleteTestAsync(id);
        }
    }
}