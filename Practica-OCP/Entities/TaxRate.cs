namespace Practica_OCP.Entities
{
    public class TaxRate
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public decimal Rate { get; set; }
        public decimal MinIncome { get; set; }
        public decimal MaxIncome { get; set; }
    }

}
