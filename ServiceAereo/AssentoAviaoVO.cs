using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServicoAereo
{
    [DataContract]
    public class AssentoAviaoVO
    {
        [DataMember]
        public int Numero { get; set; }
        
        [DataMember]
        public string Fileira { get; set; }

        [DataMember]
        public bool Livre { get; set; }
    }
}
