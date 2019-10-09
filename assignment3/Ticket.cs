using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        int ticketID;

        //op dit moment is het niet mogelijk om verschillende btw tarieven te hanteren. alles gaat volgens het standaar btw tarief van 21%, mocht er ooit verschil in gaan komen
        //kan dat hiet makkelijk aangepast worden.

        public float GetBTW()
        { return 0.21f; }

        public void GetTreininfo()
        {
            //we hebben nog geen treininformatie aanwezig van de treinen. deze functie kan het informatie eventueel ophalen uit een database.
        }

        public string GetTicketInfo(UIInfo info)
        {
            string clss = info.Class.ToString();
            string type = info.Way.ToString();
            string discount = info.Discount.ToString();
            string payment = info.Payment.ToString();

            return "class: " + clss + "\n" + "Tickettype: " + type + "\n" + "Discount: " + discount + "\n" + "Payment Method: " + payment;
        }
    }
}
