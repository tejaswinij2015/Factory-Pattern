using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Factory;
using FactoryPattern.Model;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Hello!!! Specify the card type you would like to see (moneyback/titanium/platinum): ");
            string card = Console.ReadLine();
            switch (card.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackCard(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumCard(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumCard(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}
