using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.WaterControls
{
    public class WaterControl : BaseEntity
    {
        public DateTime DayHour { get; set; }
        public decimal CDE { get; set; }
        public decimal PH { get; set; }
        public decimal CelsiusDegree { get; set; }

        public WaterControl()
        {

        }
    }
}
