using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.WashingPipes
{
    public class WashingPipe : BaseEntity
    {
        public DateTime DayHour { get; set; }
        public WashingMode Mode { get; set; }
        public WashingUsedProducts UsedProds { get; set; }

        public WashingPipe()
        {

        }
    }
}
