using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using ServiceCompositionAgencia.ServiceComponentAereo;
using ServiceCompositionAgencia.ServiceComponentCorreio;
using ServiceCompositionAgencia.ServiceComponentHotel;
using ServiceCompositionAgencia.ServiceComponentTerrestre;

namespace ServiceCompositionAgencia
{
    [ServiceContract]
    public interface IServiceAgencia
    {

        [OperationContract]
        InformacaoQuartosVO VerificarQuartos(int codigoHotel, DateTime data);

        [OperationContract]
        ReservaVO ReservarQuarto(int codigoHotel, string nome, DateTime data, int codigoTipoQuarto);

        [OperationContract]
        EnderecoVO ObterEndereco(string cep);

        [OperationContract]
        InformacaoAviaoVO VerificarPrecosAviao(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data);

        [OperationContract]
        ReservaAviaoVO ComprarPassagemAviao(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento, string fileira);

        [OperationContract]
        InformacaoOnibusVO VerificarPrecosOnibus(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data);

        [OperationContract]
        ReservaOnibusVO ComprarPassagemOnibus(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento);

    }
}