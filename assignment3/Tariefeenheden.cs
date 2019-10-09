using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
	public static class Tariefeenheden
	{
		public static String[] getStations()
		{
			return new String[] {
				"Utrecht Centraal",
				"Gouda",
				"Geldermalsen",
				"Hilversum",
				"Duivendrecht",
				"Weesp"
			};
		}

        public static int getTariefeenheden(String from, String to)
        {
            List<tariefdatabase> Tariefdatabase = new List<tariefdatabase>();

            //Elke tarief moet geregistreerd worden, normaal in een database, maar aangezien we limited zijn tot c# een eigen "database". Een station toevoegen
            //is nu makkelijker en zonder teveel moeite. je voegt simpel weg in de "database" je nieuwe station in en naar waar je kan reizen met het behorende
            //tarief. je hoeft hievoor dus geen oude code aantepassen of regels toe te voegen. dit maakt het allemaal net wat overizichtelijker :)

            Tariefdatabase.Add(new tariefdatabase("Utrecht Centraal", "Gouda", 32));
            Tariefdatabase.Add(new tariefdatabase("Utrecht Centraal", "Geldermalsen", 26));
            Tariefdatabase.Add(new tariefdatabase("Utrecht Centraal", "Hilversum", 18));
            Tariefdatabase.Add(new tariefdatabase("Utrecht Centraal", "Duivendrecht", 31));
            Tariefdatabase.Add(new tariefdatabase("Utrecht Centraal", "Weesp", 33));

            Tariefdatabase.Add(new tariefdatabase("Gouda", "Geldermalsen", 58));
            Tariefdatabase.Add(new tariefdatabase("Gouda", "Hilversum", 50));
            Tariefdatabase.Add(new tariefdatabase("Gouda", "Duivendrecht", 54));
            Tariefdatabase.Add(new tariefdatabase("Gouda", "Weesp", 57));

            Tariefdatabase.Add(new tariefdatabase("Geldermalsen", "Hilversum", 44));
            Tariefdatabase.Add(new tariefdatabase("Geldermalsen", "Duivendrecht", 57));
            Tariefdatabase.Add(new tariefdatabase("Geldermalsen", "Weesp", 59));

            Tariefdatabase.Add(new tariefdatabase("Hilversum", "Duivendrecht", 18));
            Tariefdatabase.Add(new tariefdatabase("Hilversum", "Weesp", 15));

            Tariefdatabase.Add(new tariefdatabase("Duivendrecht", "Weesp", 3));

            //dit is verantwoordelijk voor het zoeken en terugsturen van het tarief 
            var tarief = Tariefdatabase.Find(x => (x.Station1 == from && x.Station2 == to) || (x.Station1 == to && x.Station2 == from));
            if (tarief == null)
                return 0; // MessageBox.Show("Unkown Route"); 
            else return tarief.Tarief; 
		}
	}
}

