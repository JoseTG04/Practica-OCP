using Microsoft.EntityFrameworkCore;
using Practica_OCP.Context;
using Practica_OCP.Entities;
using Practica_OCP.Interface;

namespace Practica_OCP
{
    public class TaxRepository : ITaxRepository
    {
        private readonly TaxDbContext _context;

        public TaxRepository(TaxDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaxRate>> GetTaxRatesForCountryAsync(string country)
        {
            return await _context.TaxRates
                .Where(tr => tr.Country == country)
                .OrderBy(tr => tr.MinIncome)
                .ToListAsync();
        }

        public async Task SaveTaxCalculationAsync(TaxCalculation calculation)
        {
            _context.TaxCalculations.Add(calculation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TaxCalculation>> GetTaxCalculationsForCountryAsync(string country)
        {
            return await _context.TaxCalculations
                .Where(tc => tc.Country == country)
                .OrderByDescending(tc => tc.CalculationDate)
                .ToListAsync();
        }
    }
}
