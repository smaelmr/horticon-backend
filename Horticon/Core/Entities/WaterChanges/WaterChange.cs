using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.WaterChanges
{
    public class WaterChange : BaseEntity
    {
        public DateTime DayHour { get; set; }
        public decimal Receita { get; set; }
        public AdditiveTypes AdditiveType { get; set; }
        public decimal AdditiveDose { get; set; }

        public WaterChange()
        {

        }
    }
}
