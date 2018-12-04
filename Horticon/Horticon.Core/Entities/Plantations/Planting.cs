using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Plantations
{
    public class Planting : BaseEntity
    {
        #region Properties

        public int Quantity { get; set; }

        public SeedType Type { get; set; }
        public SeedVariety Variety { get; set; }
        public SeedBrand Brand { get; set; }


        #endregion

        public Planting() { }
    }
}
