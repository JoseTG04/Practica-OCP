using Practica_OCP.Entities;
using Practica_OCP.Interface;

namespace Practica_OCP
{
    public class TaxCalculator
    {
        private readonly ITaxRepository _taxRepository;

        public TaxCalculator(ITaxRepository taxRepository)
        {
            _taxRepository = taxRepository;
        }

        public async Task<decimal> CalculateAsync(decimal income, decimal deduction, string country)
        {
            var taxRates = await _taxRepository.GetTaxRatesForCountryAsync(country);

            decimal taxAmount = 0.2m;

            var calculation = new TaxCalculation
            {
                Country = country,
                Income = income,
                Deduction = deduction,
                TaxAmount = taxAmount,
                CalculationDate = DateTime.UtcNow
            };

            await _taxRepository.SaveTaxCalculationAsync(calculation);

            return taxAmount;
        }
    }
}
