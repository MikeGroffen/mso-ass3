using System;
using System.Windows.Forms;

namespace Lab3
{
    // Mock CreditCard implementation
    class CreditCard : betaling  
    {
        public void Connect()
        {
            MessageBox.Show("Connecting to credit card reader");
        }

        public void Disconnect()
        {
            MessageBox.Show("Disconnecting from credit card reader");
        }

        public int BeginTransaction(float amount)
        {
            MessageBox.Show("Begin transaction 1 of " + amount + " EUR");
            return 1;
        }

        public bool EndTransaction(int id)
        {
            if (id != 1)
                return false;

            MessageBox.Show("End transaction 1");
            return true;
        }

        public void CancelTransaction(int id)
        {
            if (id != 1)
                throw new Exception("Incorrect transaction id");

            MessageBox.Show("Cancel transaction 1");
        }

        public override void Betaalmethode(UIInfo info, float prijs)
        {
            Connect();
            int ccid = BeginTransaction(prijs + 0.50f);     //een creditcard transactie kost 50 cent duurder. deze 50 cent is al inclusief btw en word daarom hier pas toepast
            EndTransaction(ccid);
            Disconnect();
        }
    }

	// Mock CreditCard implementation
	class DebitCard : betaling 
	{
		public void Connect ()
		{
			MessageBox.Show ("Connecting to debit card reader");
		}

		public void Disconnect ()
		{
			MessageBox.Show ("Disconnecting from debit card reader");
		}

		public int BeginTransaction (float amount)
		{
			MessageBox.Show ("Begin transaction 1 of " + amount + " EUR");
			return 1;
		}

		public bool EndTransaction (int id)
		{
			if (id != 1)
				return false;

			MessageBox.Show("End transaction 1");
			return true;
		}

		public void CancelTransaction (int id)
		{
			if (id != 1)
				throw new Exception ("Incorrect transaction id");

			MessageBox.Show("Cancel transaction 1");
		}

        public override void Betaalmethode(UIInfo info, float prijs)
        {
            Connect();
            int dcid = BeginTransaction(prijs);
            EndTransaction(dcid);
            Disconnect();
        }
    }
}

