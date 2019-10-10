using System;
using System.Windows.Forms;

namespace Lab3
{
	class IKEAMyntAtare2000 : betaling
	{
		public void starta()
		{
			MessageBox.Show ("Welcome!");
		}

		public void stoppa()
		{
			MessageBox.Show ("Goodbye!");
		}

		public void betala(float pris)
		{
            MessageBox.Show (0.05 * (int)Math.Round(pris / 0.05) + " EUR" );
		}
        
        public override void Betaalmethode(UIInfo info, float prijs)
        {
            starta();
            betala(prijs); 
            stoppa();
        }
	}
}

