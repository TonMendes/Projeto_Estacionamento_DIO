

using Estacionamento.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo veiculo = new Veiculo();
        Validar validar = new Validar();

        // PEGANDO PREÇO INICIAL
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
            "Digite o preço inicial:");
        bool retorno = veiculo.Validador(Console.ReadLine());
        if(retorno == true)
        {
            veiculo.valorInicial = veiculo.valorDigitado;
        }
        else
        {
            Console.WriteLine("O valor digitado está incorreto!");
        }

        // PEGANDO O PREÇO POR HORA
        Console.WriteLine("Digite o preço por hora:");
        retorno = veiculo.Validador(Console.ReadLine());
        if(retorno == true)
        {
            veiculo.valorPorHora = veiculo.valorDigitado;
        }
        else
        {
            Console.WriteLine("O valor digitado está incorreto!");
        }

        // VERIFICANDO OPÇÕES DO USUARIO
        int opcao = 0;
        while (opcao != 4)
        {
            Menu.ApresentacaoMenu();
            retorno = validar.ValidarOpcao(Console.ReadLine()); 
            if(retorno == true)
            {
                opcao = validar.valorValido;
            }
            switch (opcao)
            {
                case 1:  
                    Console.WriteLine("Informe a placa que sera cadastrada:");    
                    veiculo.CadastrarVeiculo(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Informe a placa do veiculo a ser removido:");
                    veiculo.RemoverVeiculo(Console.ReadLine());
                    break;
                case 3:
                    veiculo.ListarVeiculos();
                    break;
                case 4:

                    break;
            }

        }

    }
}