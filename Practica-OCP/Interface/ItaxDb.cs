
using Practica_OCP.Entities;

namespace Practica_OCP.Interface
{
    public interface ItaxDb
    {
        Task<List<TaxRate>> GetTaxRatesForCountryAsync(string country);
        Task SaveTaxCalculationAsync(TaxCalculation calculation);
        Task<List<TaxCalculation>> GetTaxCalculationsForCountryAsync(string country);
    }
}
