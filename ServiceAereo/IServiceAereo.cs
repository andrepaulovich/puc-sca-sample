using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServicoTerrestre;

namespace ServicoAereo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceAereo
    {

        [OperationContract]
        InformacaoAviaoVO VerificarPrecos(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data);

        [OperationContract]
        ReservaAviaoVO ComprarPassagem(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento, string fileira);

    }

}
