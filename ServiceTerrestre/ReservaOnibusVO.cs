﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServicoTerrestre
{
    [DataContract]
    public class ReservaOnibusVO
    {
        [DataMember]
        public int CodigoCidadeOrigem { get; set; }

        [DataMember]
        public int CodigoCidadeDestino { get; set; }

        [DataMember]
        public int Assento { get; set; }

        [DataMember]
        public DateTime Data { get; set; }
    }
}
