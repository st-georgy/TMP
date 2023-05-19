using abstract_factory.@abstract;

namespace abstract_factory.concrete
{
    public class AlphaCreditProduct : ICreditProduct
    {
        public decimal Principal { get; set; }
        public int Term { get; set; }

        public AlphaCreditProduct(decimal principal, int term)
        {
            Principal = principal;
            Term = term;
        }

        public decimal GetInterestRate() => 1;

        public decimal GetMonthlyPayment(decimal principal, int term) => 1;
    }
}
