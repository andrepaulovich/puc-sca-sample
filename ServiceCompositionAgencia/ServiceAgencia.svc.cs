using System;
using System.ServiceModel;
using ServiceCompositionAgencia.ServiceComponentAereo;
using ServiceCompositionAgencia.ServiceComponentCorreio;
using ServiceCompositionAgencia.ServiceComponentHotel;
using ServiceCompositionAgencia.ServiceComponentTerrestre;

namespace ServiceCompositionAgencia
{
    
    public class ServiceAgencia : IServiceAgencia
    {
        
        public InformacaoQuartosVO VerificarQuartos(int codigoHotel, DateTime data)
        {
            
            var factory = new ChannelFactory<IServiceHotel>("*");
            var channel = factory.CreateChannel();

            return channel.VerificarQuartos(codigoHotel, data);
            
        }

        public ReservaVO ReservarQuarto(int codigoHotel, string nome, DateTime data, int codigoTipoQuarto)
        {

            var factory = new ChannelFactory<IServiceHotel>("*");
            var channel = factory.CreateChannel();

            return channel.ReservarQuarto(codigoHotel, nome, data, codigoHotel);

        }

        public EnderecoVO ObterEndereco(string cep)
        {

            var factory = new ChannelFactory<IServiceCorreio>("*");
            var channel = factory.CreateChannel();

            return channel.ObterEndereco(cep);

        }

        public InformacaoAviaoVO VerificarPrecosAviao(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data)
        {

            var factory = new ChannelFactory<IServiceAereo>("*");
            var channel = factory.CreateChannel();

            return channel.VerificarPrecos(codigoCidadeOrigem, codigoCidadeDestino, data);

        }

        public ReservaAviaoVO ComprarPassagemAviao(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento, string fileira)
        {

            var factory = new ChannelFactory<IServiceAereo>("*");
            var channel = factory.CreateChannel();

            return channel.ComprarPassagem(codigoCidadeOrigem, codigoCidadeDestino, data, numeroAssento, fileira);

        }

        public InformacaoOnibusVO VerificarPrecosOnibus(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data)
        {

            var factory = new ChannelFactory<IServiceTerrestre>("*");
            var channel = factory.CreateChannel();

            return channel.VerificarPrecos(codigoCidadeOrigem, codigoCidadeDestino, data);

        }

        public ReservaOnibusVO ComprarPassagemOnibus(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento)
        {

            var factory = new ChannelFactory<IServiceTerrestre>("*");
            var channel = factory.CreateChannel();

            return channel.ComprarPassagem(codigoCidadeOrigem, codigoCidadeDestino, data, numeroAssento);

        }

    }

}
