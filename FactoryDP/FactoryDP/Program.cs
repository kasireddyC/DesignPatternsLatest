using System;

namespace FactoryDP
{
    public class Program
    {
        public static void PrintOutputDetails(ICreditCard creditCard)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            Console.WriteLine("----------------------------");
        }
        static void Main(string[] args)
        {
            CreditCardFactory creditCardFactory = new ConcreteCreditCardFactory();
            ICreditCard platinumCard = creditCardFactory.GetCard("Platinum");
            if (platinumCard != null)
            {
                PrintOutputDetails(platinumCard);
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            ICreditCard moneyBackCard = creditCardFactory.GetCard("MoneyBack");
            if (moneyBackCard != null)
            {
                PrintOutputDetails(moneyBackCard);
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            ICreditCard titaniumCard = creditCardFactory.GetCard("Titanium");
            if (titaniumCard != null)
            {
                PrintOutputDetails(titaniumCard);
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
