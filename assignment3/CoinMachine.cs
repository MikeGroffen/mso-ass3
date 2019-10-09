using System;
using System.Windows.Forms;

namespace Lab3
{
	class IKEAMyntAtare2000 : betaling
	{
		public void starta()
		{
			MessageBox.Show ("Välkommen till IKEA Mynt Ätare 2000");
		}

		public void stoppa()
		{
			MessageBox.Show ("Hejdå!");
		}

		public void betala(int pris)
		{
            MessageBox.Show (pris + " cent" );
		}
        
        public override void Betaalmethode(UIInfo info, float prijs)
        {
            starta();
            betala((int)Math.Round(prijs * 100));
            stoppa();
        }
	}
}

