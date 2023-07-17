using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("salary")]
    public class SalaryController : Controller
    {
        private ISalaryCalculator _calculator;

        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            _calculator = injectedCalculator;
        }

        [HttpGet("{montantAnnuel}")]
        public Double Get(Double montantAnnuel)
        {
            Double calculatedSalary = _calculator.CalculateSalary(montantAnnuel);
            return calculatedSalary;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
