using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory creditCardFactory = new ConcreteCreditCardFactory();
            ICreditCard platinumCard = creditCardFactory.GetCard("Platinum");
            if (platinumCard != null)
            {
                Console.WriteLine("Card Type : " + platinumCard.GetCardType());
                Console.WriteLine("Credit Limit : " + platinumCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + platinumCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            ICreditCard moneyBackCard = creditCardFactory.GetCard("MoneyBack");
            if (moneyBackCard != null)
            {
                Console.WriteLine("Card Type : " + moneyBackCard.GetCardType());
                Console.WriteLine("Credit Limit : " + moneyBackCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + moneyBackCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            ICreditCard titaniumCard = creditCardFactory.GetCard("Titanium");
            if (titaniumCard != null)
            {
                Console.WriteLine("Card Type : " + titaniumCard.GetCardType());
                Console.WriteLine("Credit Limit : " + titaniumCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + titaniumCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
