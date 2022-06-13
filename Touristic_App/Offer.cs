using System;
namespace Touristic_App
{
    public class Offer
    {
        public string Destination { get; set; }
        public string Hotel { get; set; }
        public decimal Price { get; set; }
        public int Stars { get; set; }
        public string HolidayType { get; set; }
        
        public Offer()
        {
            Destination = "";
            Hotel = "";
            Price = 0.00M;
            Stars = 0;
            HolidayType = "";

        }
        public Offer(string d, string h, int s, string ht, decimal p)
        {
            Destination = d;
            Hotel = h;
            Price = p;
            Stars = s;
            HolidayType = ht;
        }
         override public string ToString()
        {
            return "\n\tKierunek: " + Destination + " \n\tHotel: " + Hotel + " \n\tLiczba *" + Stars + " \n\tPoziom Wyżywienia: " + HolidayType + " \n\tCena: PLN" + Price;
        }
    }
}
