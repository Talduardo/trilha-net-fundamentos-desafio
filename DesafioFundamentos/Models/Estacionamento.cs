using System.IO.Compression;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementando a solicitação do usuario para digitar a placa e adicionar na lista veiculos
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); // criando a variável placa
            veiculos.Add(placa);
            Console.WriteLine("Veículo estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Implementando a solicitação do usuario para digitar a placa e remover na lista veiculos
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //Implementando a solicitação do usuario para digitar a quantidade de horas
                // Implementando o cálculo do preco, exibindo o preco total          
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                Console.WriteLine($"O veículo {placa} permaneceu {horas} horas no estacionamento.");

                veiculos.Remove(placa);
                // Implementando a remoção do veículo
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos) // criando um laço de repetição
                {
                    Console.WriteLine(veiculo); // exibindo os veículos
                }

            }
            //Crindo um laço de repetição para exibir os veículos estacionados...
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
