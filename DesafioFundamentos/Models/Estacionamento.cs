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
            //Adição de veículo à lista - Implementado
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("\nVeículo cadastrado com sucesso.\n");
        }

        public void RemoverVeiculo()
        {
            //Solicitação para digitar a placa e armazena-la na variável adequada - Implementado
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                //Cálculo do valor total a pagar - Implementado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = precoInicial + precoPorHora * horas;
                //Remoção do veiculo da lista - Implementado
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {Decimal.Round(valorTotal, 2)}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.\n");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Laço de repetição implementado - Implementado
                foreach(string placa in veiculos)
                {
                    Console.WriteLine($"Placa - {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.\n");
            }
        }
    }
}
