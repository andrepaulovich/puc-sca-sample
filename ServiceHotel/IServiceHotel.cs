using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceHotel
{
    
    [ServiceContract]
    public interface IServiceHotel
    {

        [OperationContract]
        InformacaoQuartosVO VerificarQuartos(int codigoHotel, DateTime data);

        [OperationContract]
        ReservaVO ReservarQuarto(int codigoHotel, string nome, DateTime data, int codigoTipoQuarto);
        
    }

}
