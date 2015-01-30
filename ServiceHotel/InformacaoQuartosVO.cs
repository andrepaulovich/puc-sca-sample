using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceHotel
{
    [DataContract]
    public class InformacaoQuartosVO
    {

        [DataMember]
        public int CodigoHotel { get; set; }

        [DataMember]
        public List<QuartoVO> Quartos { get; set; }

        [DataMember]
        public DateTime Data { get; set; }

    }
}