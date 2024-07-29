namespace Practica_OCP.Entities
{
    public class TaxCalculation
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public decimal Income { get; set; }
        public decimal Deduction { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime CalculationDate { get; set; }
    }
}
