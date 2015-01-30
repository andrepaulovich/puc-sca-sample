using System;
using System.Collections.Generic;
using ServicoTerrestre;

namespace ServicoAereo
{
    
    public class ServiceAereo : IServiceAereo
    {
        public InformacaoAviaoVO VerificarPrecos(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data)
        {
            var random = new Random();

            var info = new InformacaoAviaoVO()
            {
                CodigoCidadeDestino = codigoCidadeDestino,
                CodigoCidadeOrigem = codigoCidadeOrigem,
                Data = data,
                Assentos = new List<AssentoAviaoVO>()
            };

            var fileiras = new string[] {"A", "B", "C", "D", "E", "F"};

            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    info.Assentos.Add(new AssentoAviaoVO()
                    {
                        Livre = random.Next(0, 5)%2 == 0,
                        Numero = i,
                        Fileira = fileiras[j]
                    });
                }
            }

            return info;
        }

        public ReservaAviaoVO ComprarPassagem(int codigoCidadeOrigem, int codigoCidadeDestino, DateTime data, int numeroAssento, string fileira)
        {
            return new ReservaAviaoVO()
            {
                Assento = numeroAssento,
                Fileira = fileira,
                Data = data,
                CodigoCidadeOrigem = codigoCidadeOrigem,
                CodigoCidadeDestino = codigoCidadeDestino
            };
        }
    }
}
