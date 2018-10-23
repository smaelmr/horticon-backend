using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Cycles
{
    public class Cycle : BaseEntity
    {

        public DateTime Semeado { get; set; }
        public DateTime Banca { get; set; }
        public DateTime FiftyMm { get; set; }
        public DateTime SeventyFiveMm { get; set; }
        public DateTime Colhido { get; set; }
        public string Entregue { get; set; }

        public Cycle()
        {

        }
    }
}
