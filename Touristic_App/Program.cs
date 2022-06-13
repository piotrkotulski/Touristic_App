using System;

namespace Touristic_App
{
    class Program
    {
        static readonly TourAgencyMethods NewAgent = new TourAgencyMethods();
        static void Main(string[] args)
        {
            TravelAgency Ta = new TravelAgency();
            Console.WriteLine("Witaj w biurze podróży TUTAKA TRAVEL,\n z nami spędzisz wakacje marzeń");
            Console.WriteLine("=======================================");
            Console.WriteLine("                                 ");
            Console.WriteLine("******  ****   **  *   *  ***  *");
            Console.WriteLine("  **    * *   ****  * *   **   *");
            Console.WriteLine("  **    *  *  *  *   *    ***  ***");
            Console.WriteLine("=======================================");
            int action = NewAgent.optionPanel();
            Console.Clear();
            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        NewAgent.printDefaultListCart(Ta);
                        break;

                    case 2:
                        NewAgent.printDestinationList(Ta);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Zdecydowałeś się kupić jedną z naszych ofert");
                        Console.WriteLine("=======================================");

                        Console.WriteLine("Wybierz kryteria wyszukiwania \n\n");
                        Console.WriteLine("(1) Wyszukiwanie po destynacji (Egipt, Grecja, Hiszpania ) ");
                        Console.WriteLine("\n(2) Wyszukiwanie zaawansowane (Kierunek, Hotel, Cena..) ");
                        int num = int.Parse(Console.ReadLine());

                        if (num == 1)
                        {
                            NewAgent.SearchBydestination(Ta);
                        }
                        else
                        {
                            NewAgent.advancedSearch(Ta);
                        }
                        break;

                    case 4:
                        Console.Clear();
                        NewAgent.printShoppingList(Ta);
                        Console.WriteLine("\n\nCana za wszytkich uczestników wynosi ${0}\n\n", Ta.Checkout());
                        Console.WriteLine("Dziękujemy za skorzystanie z naszej oferty, życzymy udanej podróży!\n\n");
                        break;


                    case 8:
                        Console.WriteLine(
                        "Po pierwsze pomyśl gdzie chcesz spędzić swój urlop " +
                        "\nJeżeli chcesz wyszukać dostępne obiekty wybierz właściwą opcję" +
                        "\nOstatnią czynnością którą musisz wykonać to zakup i rezerwacja.");
                        break;
                    default:
                        break;
                }

                action = NewAgent.optionPanel();
                Console.Clear();
            }
        }

    }
}
