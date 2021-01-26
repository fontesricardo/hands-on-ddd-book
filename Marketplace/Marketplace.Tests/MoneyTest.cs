﻿using Marketplace.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Marketplace.Tests
{
    public class MoneyTest
    {
        [Fact]
        public void
        Money_objects_with_the_same_amount_should_be_equal()
        {
            var firstAmount = new Money(5);
            var secondAmount = new Money(5);

            Assert.Equal(firstAmount, secondAmount);
        }

        [Fact]
        public void
        Money_objects_with_the_different_amount_should_not_be_equal()
        {
            var firstAmount = new Money(5);
            var secondAmount = new Money(6);

            Assert.NotEqual(firstAmount, secondAmount);
        }
    }
}
