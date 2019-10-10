using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class SalesLineItem
    {
        //berekent het subtotal die vervolgens word gebrhikt in de sales
        public float CalcSubTotal(UIInfo info)
        {
            Ticketinfo ticketinfo = new Ticketinfo();

            // Get number of tariefeenheden
            int tariefeenheden = Tariefeenheden.getTariefeenheden(info.From, info.To);

            // Get price
            float price = PricingTable.getPrice(tariefeenheden, ticketinfo.Tablecolumn(info));

            if (info.Way == UIWay.Return)
            {
                price *= 2;
            }


            return price;
        }


        //bedrijven hoeven voor een ticket misschien minder btw te betalen dan een ander persoon. de btw word daarom per item berekent en niet op het einde van de verkoop.
        // echter is op dit moment het btw tarief nog hetzelfde voor iedereen. de functie is met gedachte voor de toekomst al geplaats. 
        public float CalcSubtotaalBTW(UIInfo info)
        {
            Ticket ticket = new Ticket();
            return CalcSubTotal(info) * (ticket.GetBTW() + 1);
        }
    }
}
