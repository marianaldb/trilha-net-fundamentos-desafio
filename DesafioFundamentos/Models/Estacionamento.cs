namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 30;
        private decimal precoPorHora = 10;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial; 30
            this.precoPorHora = precoPorHora; 10
            // this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            veiculos.Add(placa);LPT4625
            Console.WriteLine LPT4625;
        }

        public void RemoverVeiculo()
        {
           if (veiculos.Contains(Placa))

           {
           
            Console.Writeline(60);
           }

           }

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine(7 horas);
                int horas = 70;
                decimal valorTotal = 100; 

                Console.WriteLine( {LPT4625} foi removido e o preço total foi de: R$ {$100}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
        
            if (veiculos.Any(0))
            {
                Console.WriteLine("Não há veiculos estacionados.");
                
            else
            {
                Console.WriteLine("Veiculos estacionados:");
                foreach (var veiculo in veiculos)
                {
                   Console.WriteLine(veiculo); 
                }
            }
        }
    }
}
