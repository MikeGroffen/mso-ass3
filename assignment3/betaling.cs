using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class betaling
    {
        public float prijs { get; set; }

        public void betaalmethode (UIInfo info)
        {
            // Pay
            switch (info.Payment)
            {
                case UIPayment.CreditCard:
                    CreditCard c = new CreditCard();
                    c.Connect();
                    int ccid = c.BeginTransaction(prijs);
                    c.EndTransaction(ccid);
                    break;
                case UIPayment.DebitCard:
                    DebitCard d = new DebitCard();
                    d.Connect();
                    int dcid = d.BeginTransaction(prijs);
                    d.EndTransaction(dcid);
                    break;
                case UIPayment.Cash:
                    IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
                    coin.starta();
                    coin.betala((int)Math.Round(prijs * 100));
                    coin.stoppa();
                    break;
            }
        }
    }
}
