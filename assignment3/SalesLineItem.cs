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
            int clss;
            int discount;

            // Get number of tariefeenheden
            int tariefeenheden = Tariefeenheden.getTariefeenheden(info.From, info.To);

            //kijkt welke class de gebruiker heeft geselecteert. 
            if (info.Class == UIClass.FirstClass)
                clss = 3;
            else clss = 0;

            //kijkt hoeveel korting de gebruikter krijgt
            if (info.Discount == UIDiscount.TwentyDiscount)
                discount = 1;
            else if (info.Discount == UIDiscount.FortyDiscount)
                discount = 2;
            else discount = 0;

            //berekent de totale tableColumn
            int tableColumn = clss + discount;

            // Get price
            float price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (info.Way == UIWay.Return)
            {
                price *= 2;
            }

            // Add 50 cent if paying with credit card
            if (info.Payment == UIPayment.CreditCard)
            {
                price += 0.50f;
            }

            return price;
        }

        //bedrijven hoeven voor een ticket misschien minder btw te betalen dan een ander persoon. de btw word daarom per item berekent en niet op het einde van de verkoop.
        public float CalcSubtotaalBTW(UIInfo info)
        {
            Ticket ticket = new Ticket();
            return CalcSubTotal(info) * (ticket.GetBTW() + 1);
        }
    }
}
