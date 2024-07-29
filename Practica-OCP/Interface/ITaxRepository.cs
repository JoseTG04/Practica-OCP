
using Practica_OCP.Entities;

namespace Practica_OCP.Interface
{
    public interface ITaxRepository
    {
        Task<List<TaxRate>> GetTaxRatesForCountryAsync(string country);
        Task SaveTaxCalculationAsync(TaxCalculation calculation);
        Task<List<TaxCalculation>> GetTaxCalculationsForCountryAsync(string country);
    }
}
