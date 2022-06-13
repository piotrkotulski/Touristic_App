using System;
using System.Collections.Generic;
using System.Text;

namespace Touristic_App
{
    public interface ITourAgencyMethods
    {
        void SearchBydestination(TravelAgency Ta);
        void advancedSearch(TravelAgency Ta);
        void printDefaultListCart(TravelAgency Ta);
        void printShoppingCart(TravelAgency Ta);
        void printShoppingList(TravelAgency Ta);
        void printAll(TravelAgency Ta);
        void printDestinationList(TravelAgency Ta);
        int  optionPanel();
    }
}
