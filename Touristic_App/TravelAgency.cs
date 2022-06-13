using System;
using System.Collections.Generic;
using System.Text;

namespace Touristic_App
{
    public class TravelAgency
    {
        public List<Offer> OfferList { get; set; }
        public List<Offer> ShoppingList { get; set; }

        public TravelAgency()
        {
            OfferList = new List<Offer>();
            ShoppingList = new List<Offer>();

            OfferList.Add(new Offer { Destination = "Egipt", Hotel = "Safira Palms", Stars = 1, HolidayType ="All Inclusive",  Price = 1243 });
            OfferList.Add(new Offer { Destination = "Egipt", Hotel = "Hilton", Stars = 2, HolidayType = "All Inclusive", Price = 3421 });
            OfferList.Add(new Offer { Destination = "Egipt", Hotel = "Steigenberger", Stars = 3, HolidayType = "All Inclusive", Price = 1999 });
            OfferList.Add(new Offer { Destination = "Egipt", Hotel = "Novotel", Stars = 4, HolidayType = "All Inclusive", Price = 2750 });
            OfferList.Add(new Offer { Destination = "Egipt", Hotel = "Jaz Maraya", Stars = 5, HolidayType = "All Inclusive", Price = 6439 });
            OfferList.Add(new Offer { Destination = "Grecja", Hotel = "Kalithea Horizon Royal", Stars = 4, HolidayType = "All Inclusive", Price = 3222 });
            OfferList.Add(new Offer { Destination = "Grecja", Hotel = "Kakkos Beach", Stars = 4, HolidayType = "All Inclusive", Price = 5000 });
            OfferList.Add(new Offer { Destination = "Grecja", Hotel = "Mitsis Alila Resort", Stars = 5, HolidayType = "All Inclusive", Price = 1230 });
            OfferList.Add(new Offer { Destination = "Grecja", Hotel = "Atlantica Beach", Stars = 4, HolidayType = "All Inclusive", Price = 6500 });
            OfferList.Add(new Offer { Destination = "Grecja", Hotel = "Poseidon", Stars = 4, HolidayType = "All Inclusive", Price = 3200 });
            OfferList.Add(new Offer { Destination = "Hiszpania", Hotel = "Iberostar Selection", Stars = 5, HolidayType = "All Inclusive", Price = 2700 });
            OfferList.Add(new Offer { Destination = "Hiszpania", Hotel = "Sentido White Suites", Stars = 4, HolidayType = "All Inclusive", Price = 4300 });
            OfferList.Add(new Offer { Destination = "Hiszpania", Hotel = "RIU Palace Palmeras", Stars = 4, HolidayType = "All Inclusive", Price = 11000 });
            OfferList.Add(new Offer { Destination = "Hiszpania", Hotel = "Las Costas", Stars = 5, HolidayType = "All Inclusive", Price = 4500 });
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }
            Console.WriteLine("Ilość podróżujących osób osób");
            int numOfClients = int.Parse(Console.ReadLine());

            ShoppingList.Clear();
            return totalCost * numOfClients;
        }
    }
}
