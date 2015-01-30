using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceHotel
{
    [DataContract]
    public class QuartoVO
    {
        [DataMember]
        public int Tipo { get; set; }

        [DataMember]
        public decimal Valor { get; set; }

        [DataMember]
        public bool Televisao { get; set; }

        [DataMember]
        public bool Hidromassagem { get; set; }

        [DataMember]
        public bool Vista { get; set; } 
    }
}
