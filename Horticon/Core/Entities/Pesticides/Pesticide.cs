using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Pesticides
{
    public class Pesticide : BaseEntity
    {
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string CommercialName { get; set; }
        public string PesticideType { get; set; }
        public string ActivePrinciple { get; set; }
        public string DoseL { get; set; }
        public string Lack { get; set; } //carencia
        
    }
}
