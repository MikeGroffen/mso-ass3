using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class sales
    {
        public string Datum { get; set; }
        public string Tijd { get; set; }

        //een gebruiker kan meerdere van dezelfde tikets te gelijk kopen. bijvoorbeeld als deze met een groep van 4 personen zijn. echter kan ik niet in de gui een optie aanmaken
        // waar ik een amount in kan vullen. de amount is dus nog standaard 1 totdat er een update komt waar dit wel mogelijk gaat zijn.
        int Amount = 1;

        public float CalcTotal(UIInfo info)
        {
            SalesLineItem salelineitem = new SalesLineItem();
            return (float)Math.Round(salelineitem.CalcSubtotaalBTW(info) * Amount, 2);
        }
    }
}
