using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string card;
            Console.WriteLine("Introduce your card number: ");
            card = Console.ReadLine();

            var facade = new CardFacade();
            var results = facade.getCardResults(card);

            Console.WriteLine(results);
            Console.ReadKey();
        }
    }
}
