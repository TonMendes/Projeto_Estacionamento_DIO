using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entities
{
    internal class Veiculo
    {
        public string placaVeiculo { get; set; } = string.Empty;
        public double valorInicial { get; set; }    
        public double valorPorHora {  get; set; }

        public List<string> listaVeiculos = new List<string>(); 
        public double valorDigitado = 0;


        public bool Validador(string valorUsuario)
        {

            bool valido;

            try
            {
                double valor = 0;
                if(double.TryParse(valorUsuario, out valor))
                {
                    valido = true;
                    valorDigitado = valor;
                }
                else
                {
                    valido = false;
                }

            }catch (Exception)
            {
                valido = false;
            }

            return valido;
        }

        public void CadastrarVeiculo(string placa)
        {
            placa = placa.ToUpper();
            
                try
                {
                    if (listaVeiculos.Contains(placa))
                    {
                        Console.WriteLine("Placa ja Cadastrada!");
                    }
                    else
                    {
                        listaVeiculos.Add(placa);
                        Console.WriteLine("Placa cadastrada com sucesso!");
                    }
                }
                catch (Exception) { }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Os veiculos cadastrados são:");

            foreach(string placas in listaVeiculos)
            {
                Console.WriteLine(placas);
            }
        }

        public void RemoverVeiculo(string placa)
        {
            placa = placa.ToUpper();

            if (listaVeiculos.Contains(placa))
            {
                try
                {
                    listaVeiculos.RemoveAll(placas => placas == placa);
                    Console.WriteLine($"Placa {placa} removida com sucesso!");

                    Console.WriteLine("Inform o tempo de estadia:");
                    double tempo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A placa {placa} foi removida com sucesso!\n" +
                        $"O valor a ser pago é de R${(valorInicial + (valorPorHora * tempo))}");

                }
                catch (Exception) { }
            } else
            {
                Console.WriteLine("A placa informada não foi encontrada!");
            }
        }
    }
}
