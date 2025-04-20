using System;

namespace UnifiedContract.Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money() { }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency?.ToUpper() ?? "SAR";
        }

        public static Money FromSAR(decimal amount)
        {
            return new Money(amount, "SAR");
        }

        public override string ToString()
        {
            return $"{Amount:N2} {Currency}";
        }
    }
} 