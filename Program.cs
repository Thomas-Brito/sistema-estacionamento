Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

Console.WriteLine("Digite o preço inicial:");

double precoInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");

double precoPorHora = Convert.ToInt32(Console.ReadLine());

List<string> veiculos = [];

bool condicao = true;

void AguardarEntrada()
{
  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadKey();
}

while (condicao)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar");

  string opcaoSelecionada = Console.ReadLine() ?? "";

  switch (opcaoSelecionada)
  {
    case "1":
      {
        Console.Clear();
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        veiculos.Add(Console.ReadLine() ?? "");
        AguardarEntrada();
      }
      break;

    case "2":
      {
        Console.Clear();
        Console.WriteLine("Digite a placa do veículo para remover:");

        string veiculoRemovido = Console.ReadLine() ?? "";

        if (veiculos.Contains(veiculoRemovido))
        {
          veiculos.Remove(veiculoRemovido);
          Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
          double quantidadeHoras = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"O veículo {veiculoRemovido} foi removido e o preço total foi de R$ {precoInicial + precoPorHora * quantidadeHoras}.");
          AguardarEntrada();
        }
        else
        {
          Console.WriteLine("O placa do veículo digitada não consta no registro.");
          AguardarEntrada();
        }
        ;
      }
      break;

    case "3":
      {
        Console.Clear();
        Console.WriteLine("Os veículos estacionados são:");
        for (int i = 0; i < veiculos.Count; i++)
        {
          Console.WriteLine(veiculos[i]);
        }
        AguardarEntrada();
      }
      break;

    case "4":
      {
        Console.Clear();
        AguardarEntrada();
        Console.WriteLine("O programa se encerrou.");
        condicao = false;
      }
      break;

    default:
      {
        Console.Clear();
        Console.WriteLine("Digite uma opção válida.");
        AguardarEntrada();
      }
      break;
  }
}