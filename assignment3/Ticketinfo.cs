using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticketinfo
    {
        public string clss(UIInfo info) { return info.Class.ToString(); }
        public string type(UIInfo info) { return info.Way.ToString(); }
        public string discount(UIInfo info) { return info.Discount.ToString(); }
        
        public int Tablecolumn(UIInfo info)
        {
            int clss;
            int discount;
            
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

            //returnt de totale tableColumn
            return  clss + discount;
        }
    }
}
