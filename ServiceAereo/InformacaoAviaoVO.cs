using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using ServicoTerrestre;

namespace ServicoAereo
{
    [DataContract]
    public class InformacaoAviaoVO
    {
        [DataMember]
        public int CodigoCidadeOrigem { get; set; }

        [DataMember]
        public int CodigoCidadeDestino { get; set; }

        [DataMember]
        public List<AssentoAviaoVO> Assentos { get; set; }

        [DataMember]
        public DateTime Data { get; set; }
    }
}
