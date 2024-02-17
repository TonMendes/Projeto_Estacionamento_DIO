using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entities
{
    internal class Menu
    {
        public static void ApresentacaoMenu()
        {
            Console.WriteLine("Digite a sua opção:\n" +
                "1 - Cadastrar veículo\n" +
                "2 - Remover veículo\n" +
                "3 - Listar veículo\n" +
                "4 - Encerrar");
        }
    }
}
