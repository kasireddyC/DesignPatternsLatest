﻿using System;

namespace FactoryDP
{
    public class ConcreteCreditCardFactory : CreditCardFactory
    {
        public override ICreditCard GetCard(string cardType)
        {
            switch (cardType)
            {
                case "Platinum":
                    return new PlatinumCard();
                case "MoneyBack":
                    return new MoneyBackCard();
                case "Titanium":
                    return new TitaniumCard();
                default:
                    throw new ApplicationException(string.Format("Card '{0}' cannot be created", cardType));
            }
        }
    }
}
