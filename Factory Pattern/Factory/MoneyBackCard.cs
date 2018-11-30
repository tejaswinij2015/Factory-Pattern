﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Model;

namespace FactoryPattern.Factory
{
    class MoneyBackCard:CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCard(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
