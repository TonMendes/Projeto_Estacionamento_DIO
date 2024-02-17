using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entities
{
    internal class Validar
    {
        public int valorValido {  get; set; }

        Veiculo veiculo = new Veiculo();

        public bool ValidarOpcao(string ValorInformado)
        {
            bool retorno = false;
            int valor;

            if (int.TryParse(ValorInformado, out valor))
            {
                valorValido = valor;
                retorno = true;
            }
            else
            {
                Console.WriteLine("Por favor, informe uma opção valida!");
                retorno = false;
            }

            return retorno;
        }
    }
}
