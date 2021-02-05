﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class Price : Money
    {
        private Price(decimal amount, string currencyCode, ICurrencyLookup currencyLookup)
           : base(amount, currencyCode, currencyLookup)
        {
            if (amount < 0)
                throw new ArgumentException(
                    "Price cannot be negative",
                    nameof(amount));
        }

        public new static Price FromDecimal(decimal amount, string currency,
            ICurrencyLookup currencyLookup) =>
            new Price(amount, currency, currencyLookup);
    }
}
