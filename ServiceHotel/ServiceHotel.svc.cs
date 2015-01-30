using System;
using System.Collections.Generic;
using System.ServiceModel;
using Compartilhado;

namespace ServiceHotel
{

    public class ServiceHotel : IServiceHotel
    {

        public InformacaoQuartosVO VerificarQuartos(int codigoHotel, DateTime data)
        {

            var random = new Random();

            return new InformacaoQuartosVO()
            {
                CodigoHotel = codigoHotel,
                Data = data,
                Quartos = new List<QuartoVO>()
                {
                    new QuartoVO()
                    {
                        Hidromassagem = true,
                        Televisao = true,
                        Tipo = 1,
                        Valor = random.Next(100, 150),
                        Vista = true
                    },
                    new QuartoVO()
                    {
                        Hidromassagem = false,
                        Televisao = false,
                        Tipo = 2,
                        Valor = random.Next(70, 90),
                        Vista = false
                    },
                    new QuartoVO()
                    {
                        Hidromassagem = true,
                        Televisao = true,
                        Tipo = 3,
                        Valor = random.Next(120, 160),
                        Vista = true
                    },
                    new QuartoVO()
                    {
                        Hidromassagem = false,
                        Televisao = true,
                        Tipo = 2,
                        Valor = random.Next(80, 95),
                        Vista = false
                    }
                }
            };

        }

        public ReservaVO ReservarQuarto(int codigoHotel, string nome, DateTime data, int codigoTipoQuarto)
        {

            var random = new Random();
            var reserva = new ReservaVO();

            if (data > DateTime.Now)
            {

                reserva.Data = data;
                reserva.Mensagem = "Reserva realizada com sucesso para {0}.".FormatWith(nome);
                reserva.Nome = nome;
                reserva.Realizado = true;
                reserva.Quarto = new QuartoVO()
                {
                    Hidromassagem = false,
                    Televisao = true,
                    Tipo = codigoTipoQuarto,
                    Valor = random.Next(80, 95),
                    Vista = false
                };
            }

            reserva.Realizado = false;
            reserva.Mensagem = "Reserva não pode ser finalizada.";

            return reserva;

        }

    }
}
