using Praticando.Models;

decimal valorInicial = 0;
decimal valorPorHora = 0;

Console.Clear();
Console.WriteLine("Bem vindo ao sistema de estacionamento!!");
Console.WriteLine("Precione a tecla ENTER para continuar");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Digite o valor inicial:");
valorInicial = Convert.ToDecimal(Console.ReadLine());

Console.Clear();
Console.WriteLine("Digite o valor por hora:");
valorPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(valorInicial, valorPorHora);

while(true){
  Console.Clear();
  Console.WriteLine("O que deseja Fazer?");
  Console.WriteLine("1 - Cadastrar Veículo");
  Console.WriteLine("2 - Remover Veículo");
  Console.WriteLine("3 - Listar Veículos");
  Console.WriteLine("4 - Encerrar sistema");

  switch(Console.ReadLine()){
    case "1":
      estacionamento.cadastrarVeiculos();
    break;
    case "2":
      estacionamento.removerVeiculos();
    break;
    case "3":
      estacionamento.listarVeiculos();
    break;
    case "4":
      Console.Clear();
      Console.WriteLine("Programa Finalizado");
      Environment.Exit(0);
    break;
    default:
      Console.Clear();
      Console.WriteLine("Digite um valor válido!!!");
      Console.WriteLine("Precione ENTER para continuar");
      Console.ReadLine();
    break;
  }
}


