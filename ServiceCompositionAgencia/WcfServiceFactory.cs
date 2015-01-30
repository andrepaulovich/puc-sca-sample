using Microsoft.Practices.Unity;
using ServiceCompositionAgencia.ServiceComponentAereo;
using ServiceCompositionAgencia.ServiceComponentCorreio;
using ServiceCompositionAgencia.ServiceComponentTerrestre;
using Unity.Wcf;

namespace ServiceCompositionAgencia
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {

            container
                .RegisterType<IServiceAgencia, ServiceAgencia>()
                .RegisterType<IServiceAereo, IServiceAereo>()
                .RegisterType<IServiceCorreio, IServiceCorreio>()
                .RegisterType<IServiceTerrestre, IServiceTerrestre>();

        }
    }    
}