using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceCorreio
{
    
    [ServiceContract]
    public interface IServiceCorreio
    {
        [OperationContract]
        EnderecoVO ObterEndereco(string cep);
    }
    
}
