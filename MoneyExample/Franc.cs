﻿using System;

namespace MoneyExample
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
            _currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}