using System;
using System.Runtime.Serialization;

namespace ServiceHotel
{
    [DataContract]
    public class ReservaVO
    {
        [DataMember]
        public QuartoVO Quarto { get; set; }

        [DataMember]
        public string Mensagem { get; set; }

        [DataMember]
        public DateTime Data { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public bool Realizado { get; set; }
    }
}
