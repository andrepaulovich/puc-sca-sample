using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServicoTerrestre
{
    [DataContract]
    public class AssentoOnibusVO
    {
        [DataMember]
        public int Numero { get; set; }

        [DataMember]
        public bool Livre { get; set; }
    }
}
