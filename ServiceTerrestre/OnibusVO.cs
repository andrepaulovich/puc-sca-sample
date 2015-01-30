using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServicoTerrestre
{
    public class OnibusVO
    {
        [DataMember]
        public decimal Valor { get; set; }

        [DataMember]
        public bool Leito { get; set; }

        [DataMember]
        public List<AssentoOnibusVO> Assentos { get; set; } 
    }
}
