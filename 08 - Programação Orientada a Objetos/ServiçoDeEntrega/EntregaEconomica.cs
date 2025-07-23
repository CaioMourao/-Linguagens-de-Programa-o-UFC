using System;

namespace ServicoEntrega
{
    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(string nome, string enderecoOrigem, string enderecoDestino)
            : base(nome, enderecoOrigem, enderecoDestino)
        {
        }

        public override void RealizarServico()
        {
            Status = "Em andamento (Econômica)";
            Console.WriteLine("Entrega econômica iniciada. Prazo maior, custo reduzido.");
        }
    }
}
