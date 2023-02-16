using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticando.Models
{
    public class Estacionamento
    {
        //variáveis
        decimal valorInicial = 0;
        decimal valorPorHora = 0;
        string placa;
        bool condicional = true;
        List<string> veiculos = new List<string>();


        //construtor de Estacionamento
        public Estacionamento(decimal valorInicial, decimal valorPorHora){
            this.valorInicial = valorInicial;
            this.valorPorHora = valorPorHora;
        }
        

        //metodo para cadastrar veiculos
        public void cadastrarVeiculos()
        {
            Console.Clear();
            Console.WriteLine("Digite o numero da placa e aperte ENTER para confirmar:");
            placa = Console.ReadLine().ToUpper();

            if(veiculos.Any(x => x == placa)){

                Console.Clear();
                Console.WriteLine("Placa já cadastrada!!!");
                Console.WriteLine("Precione ENTER para continuar");
                Console.ReadLine();

                veiculosCadastrados();
            }
            else{
                Console.Clear();
                veiculos.Add(placa);
                Console.WriteLine("Placa adicionada com Sucesso!");
                Console.WriteLine("Precione ENTER para continuar");
                Console.ReadLine();

                veiculosCadastrados();
            }
        }


        //metodo para remover os veiculos
        public void removerVeiculos(){
            if(veiculos.Any()){
                Console.Clear();
                Console.WriteLine("Digite a placa para a remover um veículo e aperte ENTER para confirmar:");
                placa = Console.ReadLine().ToUpper();

                if(veiculos.Any(x => x == placa)){
                    int horasTotais = 0;
                    decimal totalPago = 0;

                    Console.Clear();
                    Console.WriteLine("Quantas horas o carro ficou estacionado e aperte ENTER para confirmar?");
                    horasTotais = Convert.ToInt32(Console.ReadLine());
                    totalPago = valorInicial + (valorPorHora * horasTotais);

                    veiculos.Remove(placa);
                    Console.Clear();
                    Console.WriteLine("Veículo removido com sucesso!\n" + $"O valor a ser pago é de {totalPago} reais\n");
                    Console.WriteLine("Precione ENTER para continuar");
                    Console.ReadLine();

                    veiculoRemovido();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Esse veículo não está cadastrado!");
                    Console.WriteLine("\nPrecione ENTER para continuar");
                    Console.ReadLine();
                    veiculoRemovido();
                }
            }
            else{
                Console.Clear();
                Console.WriteLine("Não existe veículos cadastrados!");
                Console.WriteLine("\nPrecione ENTER para continuar");
                Console.ReadLine();
                veiculosCadastrados();
            }
        }


        //metodo para listar os veiculos
        public void listarVeiculos(){
            if(veiculos.Any()){
                Console.Clear();
                Console.WriteLine("Esses são os veículos estacionados no momento:\n");
                foreach(string i in veiculos){
                    Console.WriteLine(i);
                }
                Console.WriteLine("\nPrecione ENTER para continuar");
                Console.ReadLine();
            }
            else{
                Console.Clear();
                Console.WriteLine("Não possui veículos cadastrados");
                Console.WriteLine("Precione ENTER para continuar");
                Console.ReadLine();
            }
        }


        //metodo para cadastrar um novo veiculo
        public void veiculosCadastrados(){
            condicional = true;
            while(condicional){
                Console.Clear();
                Console.WriteLine("Desejas Cadastrar um novo veículo? 's' ou 'n'");

                switch(Console.ReadLine().ToLower()){
                    case "s":
                        condicional = false;
                        cadastrarVeiculos();
                    break;
                    case "n":
                        condicional = false;
                        Console.Clear();
                        Console.WriteLine("Precione ENTER para continuar");
                        Console.ReadLine();
                    break;
                    default:
                        Console.WriteLine("Digite um Valor válido!!!");
                        Console.WriteLine("Precione ENTER para continuar");
                        Console.ReadLine();
                    break;
                }
            }
        }


        // metodo para remover um novo veiculo
        public void veiculoRemovido(){
            condicional = true;
            while(condicional){
                Console.Clear();
                Console.WriteLine("Você deseja remover outro veículo? 's' ou 'n'");

                switch(Console.ReadLine().ToLower()){
                    case "s":
                        condicional = false;
                        removerVeiculos();
                    break;
                    case "n":
                        condicional = false;
                        Console.Clear();
                        Console.WriteLine("Precione ENTER para continuar");
                        Console.ReadLine();
                    break;
                    default:
                        Console.WriteLine("Digite um Valor válido!!!");
                        Console.WriteLine("Precione ENTER para continuar");
                        Console.ReadLine();
                    break;
                }
            }
        }
    }
}