using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commands
{
    class PlantingPostCommand
    {
        public int System { get; set; }
        public int Lot { get; set; }
        public int Quantity { get; set; }

        public SeedType Type { get; set; }
        public SeedVariety Variety { get; set; }
        public SeedBrand Brand { get; set; }
    }
}
