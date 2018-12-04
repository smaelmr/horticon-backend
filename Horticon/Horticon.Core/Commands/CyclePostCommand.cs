using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commands
{
    public class CyclePostCommand
    {
        public int System { get; set; }
        public int Lot { get; set; }
        public DateTime Semeado { get; set; }
        public DateTime Banca { get; set; }
        public DateTime FiftyMm { get; set; }
        public DateTime SeventyFiveMm { get; set; }
        public DateTime Colhido { get; set; }
        public string Entregue { get; set; }
    }
}
