using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using Compartilhado;

namespace ServiceCorreio
{

    public class ServiceCorreio : IServiceCorreio
    {

        private const string UrlCorreio = "http://www.buscacep.correios.com.br/servicos/dnec/consultaLogradouroAction.do?Metodo=listaLogradouro&CEP={0}&TipoConsulta=cep";

        public EnderecoVO ObterEndereco(string zipcode)
        {

            var requisicao = (HttpWebRequest) WebRequest.Create(UrlCorreio.FormatWith(zipcode));
            var resposta = (HttpWebResponse) requisicao.GetResponse();
            int cont = 0;
            var buffer = new byte[1000];
            var sb = new StringBuilder();

            Stream stream = resposta.GetResponseStream();

            do
            {
                
                if (stream != null)
                {
                    cont = stream.Read(buffer, 0, buffer.Length);
                }

                string temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);

            var pagina = sb.ToString();

            if (pagina.IndexOf("CEP NAO ENCONTRADO", System.StringComparison.Ordinal) >= 0)
            {
                return null;
            }

            string logradouro = Regex.Match(pagina, "<td width=\"268\" style=\"padding: 2px\">(.*)</td>").Groups[1].Value;
            string bairro = Regex.Matches(pagina, "<td width=\"140\" style=\"padding: 2px\">(.*)</td>")[0].Groups[1].Value;
            string cidade = Regex.Matches(pagina, "<td width=\"140\" style=\"padding: 2px\">(.*)</td>")[1].Groups[1].Value;
            string estado = Regex.Match(pagina, "<td width=\"25\" style=\"padding: 2px\">(.*)</td>").Groups[1].Value;

            return new EnderecoVO()
            {
                NomeCidade = cidade,
                SiglaEstado = estado,
                Bairro = bairro,
                Logradouro = logradouro
            };

        }
        
    }

}
