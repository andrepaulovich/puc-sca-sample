using System.Runtime.Serialization;

namespace ServiceCorreio
{
    [DataContract]
    public class EnderecoVO
    {
        [DataMember]
        public string NomeCidade { get; set; }

        [DataMember]
        public string SiglaEstado { get; set; }

        [DataMember]
        public string Bairro { get; set; }

        [DataMember]
        public string Logradouro { get; set; }
    }
}
