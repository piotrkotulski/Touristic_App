using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Touristic_App
{
    public class TourAgencyMethods : ITourAgencyMethods
    {
        public void SearchBydestination(TravelAgency Ta)
        {
            Console.WriteLine("\nWpisz nazwę państwa, gdzie chcesz spędzić swój urlop: ");
            string choosenDestination = Console.ReadLine();
            var searchBy = Ta.OfferList.Where(p => p.Destination == choosenDestination);
            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"Liczba ofert spełniających Twoje kryteria wyszukiwania to: ${result}, musisz zmienić kryteria wyszukiwania");
                optionPanel();
            }
            else
            {
                Console.WriteLine($"\n{result} spełnia twoje kryteria wyszukiwania:");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nOferta lp." + i + " => " + item);
                    i++;
                }
                Console.WriteLine("Z której oferty chcesz skorzystać? (podaj właściwy numer)");
                int offerChosen = int.Parse(Console.ReadLine());

                Ta.ShoppingList.Add(searchBy.ElementAt(offerChosen));
                Ta.OfferList.Remove(searchBy.ElementAt(offerChosen));
                printShoppingCart(Ta);
            }
        }
        public void advancedSearch(TravelAgency Ta)
        {
            Console.WriteLine("\nWpisz nazwę państwa w których chcesz spędzić swój urlop: ");
            string destinationValue = Console.ReadLine();
            Console.WriteLine("\nWybierz ilu gwiazdkowe hotele Cię interesują (1-5) ");
            string hotelValue = Console.ReadLine();
            Console.WriteLine("\nMaksymalna cena za jedną osobę: ");
            int priceValue = int.Parse(Console.ReadLine());


            var searchBy = Ta.OfferList.Where(p => p.Destination == destinationValue);
            var result = searchBy.Count();

            if (result == 0)
            {
                Console.WriteLine($"Liczba ofert spełniających Twoje kryteria wyszukiwania to: ${ result}, musisz zmienić kryteria wyszukiwania");
                optionPanel();
            }
            else
            {
                Console.WriteLine($"\n{result} ofert spełnia Twoje kryteria wyszukiwania:");
                var i = 0;
                foreach (var item in searchBy)
                {
                    Console.WriteLine("\nOferta lp." + i + " => " + item);
                    i++;
                }
                Console.WriteLine("Z której oferty chcesz skorzystać ? (podaj właściwy numer)");
                int carChosen = int.Parse(Console.ReadLine());
                Ta.ShoppingList.Add(searchBy.ElementAt(carChosen));
                Ta.OfferList.Remove(searchBy.ElementAt(carChosen));
                printShoppingCart(Ta);
            }
        }
        public void printDefaultListCart(TravelAgency Ta)
        {
            printAll(Ta);
        }
        public void printShoppingCart(TravelAgency Ta)
        {
            Console.Clear();
            Console.WriteLine("Oferty, które zdecydowałeś się kupić:\n");
            for (int i = 0; i < Ta.ShoppingList.Count; i++)
            {
                Console.WriteLine("Oferta lp. " + i + " => {0}\n", Ta.ShoppingList[i]);
            }

            Console.WriteLine("ABY DOKONAĆ REZERWACJI WYBIERZ 4 \n\n\n");
        }

        public void printShoppingList(TravelAgency Ta)
        {
            for (int i = 0; i < Ta.ShoppingList.Count; i++)
            {
                Console.WriteLine("\nOferta lp. " + i + " => {0}\n", Ta.ShoppingList[i]);
            }
        }

        public void printAll(TravelAgency Ta)
        {
            for (int i = 0; i < Ta.OfferList.Count; i++)
            {
                Console.WriteLine("\nOferta lp. " + i + " => " + Ta.OfferList[i]);
            }
        }

        public void printDestinationList(TravelAgency Ta)
        {
            
            for (int i = 0; i < Ta.OfferList.Count; i++)
            {
                Console.WriteLine("\nOferta lp. " + i + " =>" + Ta.OfferList[i].Destination);
            }

            }

        public int optionPanel()
        {
            Console.ReadKey();
            
            Console.WriteLine("\n" +
                "[1] Sprawdź listę wszytkich dostępnych obiektów \n" +
                "[2] Sprawdź listę wszytkich dostępnych destynacji \n" +
                "[3] Wyszukaj obiekt   \n" +
                "[4] REZERWACJA \n\n" +

                "[7] Wyjście\n" +
                "[8] Jak korzystać z aplikacji");
                
            Console.WriteLine("========================================_");
            Console.Write($"\nWybierz czynność: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
