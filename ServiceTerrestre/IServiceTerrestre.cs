using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicoTerrestre
{
    
    [ServiceContract]
    public interface IServiceTerrestre
    {

        [OperationContract]
        InformacaoOnibusVO VerificarPrecos(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data);

        [OperationContract]
        ReservaOnibusVO ComprarPassagem(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento);

    }

}
