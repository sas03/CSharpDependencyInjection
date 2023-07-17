namespace DependencyInjection.Services
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        public Double CalculateSalary(Double montantAnnuel)
        {
            return montantAnnuel / 4;
        }
    }
}
