using System;
using System.Collections.Generic;

namespace ServicoTerrestre
{
    
    public class ServiceTerrestre : IServiceTerrestre
    {

        public InformacaoOnibusVO VerificarPrecos(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data)
        {

            var random = new Random();

            var info = new InformacaoOnibusVO()
            {
                CodigoCidadeDestino = codigoCidadeDestino,
                CodigoCidadeOrigem = codigoCidadeOrigem,
                Data = data,
                Assentos = new List<AssentoOnibusVO>()
            };

            for (int i = 0; i < 46; i++)
            {
                info.Assentos.Add(new AssentoOnibusVO()
                {
                    Livre = random.Next(0, 5) % 2 == 0,
                    Numero = i
                });
            }

            return info;

        }

        public ReservaOnibusVO ComprarPassagem(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento)
        {

            return new ReservaOnibusVO()
            {
                Assento = numeroAssento,
                Data = data,
                CodigoCidadeOrigem = codigoCidadeOrigem,
                CodigoCidadeDestino = codigoCidadeDestino
            };

        }

    }

}
