using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class sales
    {
        //een gebruiker kan meerdere van dezelfde tikets te gelijk kopen. bijvoorbeeld als deze met een groep van 4 personen zijn. echter kan ik niet in de gui een optie aanmaken
        // waar ik een amount in kan vullen. de amount is dus nog standaard 1 totdat er een update komt waar dit wel mogelijk gaat zijn. 

        // deze classe is ook handig voor later. op dit moment is het mogelijk om 1 ticket tegelijk te kopen, later willen we dit aanpassen naar meer tickets tegelijk en verschillende tickets
        //bijvoorbeeld utrecht - gouda en gouda - den haag. en natuurlijk hoeveel tickets van bijvoorbeeld utrecht naar gouda.
        public int Amount = 1;
        private betaling _betaling;

        public float CalcTotal(UIInfo info)
        {
            SalesLineItem salelineitem = new SalesLineItem();
            return (float)Math.Round(salelineitem.CalcSubtotaalBTW(info) * Amount, 2);
        }

        // sale is verantwoordelijk voor het aanmaken van een betaling
        public void Setbetaling(betaling betaal)
        {
            this._betaling = betaal;
        }

        public void payment(UIInfo info)
        {
            switch (info.Payment)
            {
                case UIPayment.CreditCard: Setbetaling(new CreditCard()); break;
                case UIPayment.DebitCard: Setbetaling(new DebitCard()); break;
                case UIPayment.Cash: Setbetaling(new IKEAMyntAtare2000()); break;
            }

            _betaling.Betaalmethode(info, CalcTotal(info));
        }

        public string betalinginfo(UIInfo info, float prijs)
        {
            string payment = info.Payment.ToString();
            return "Receipt" + "\n"
                    + "Payment Method: " + payment + "\n"
                    + "Price: " + prijs + "\n"
                    + "Date of pay: " + DateTime.Now;
        }
    }
}
