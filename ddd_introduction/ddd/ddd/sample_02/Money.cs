using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.sample_02
{
    class Money
    {
        private readonly decimal amount;
        private readonly string currency;

        public Money(decimal amount, string currency) 
        {
            if (currency == null) throw new ArgumentNullException(nameof(currency));

            this.amount = amount;
            this.currency = currency;
        }

        public Money Add(Money arg) 
        {
            if (arg == null) throw new ArgumentNullException(nameof(arg));
            if (currency != arg.currency) throw new ArgumentException(nameof(arg));

            return new Money(amount + arg.amount, currency);
        }
    }
}
