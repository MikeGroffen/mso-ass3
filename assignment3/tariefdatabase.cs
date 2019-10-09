using System;

namespace Lab3
{
    class tariefdatabase
    {
        public string Station1 { get; set; }
        public string Station2 { get; set; }
        public int    Tarief   { get; set; }

        public tariefdatabase(string station1, string station2, int tarief)
        {
            Station1 = station1;
            Station2 = station2;
            Tarief = tarief;
        }
    }
}
