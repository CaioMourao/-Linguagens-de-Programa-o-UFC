using System;

namespace ServicoEntrega
{
    public class EntregaExpresso : Entrega
    {
        public int TempoEstimadoHoras { get; set; }

        public EntregaExpresso(string nome, string enderecoOrigem, string enderecoDestino, int tempoEstimadoHoras)
            : base(nome, enderecoOrigem, enderecoDestino)
        {
            TempoEstimadoHoras = tempoEstimadoHoras;
        }

        public override void RealizarServico()
        {
            Status = "Em andamento (Expresso)";
            Console.WriteLine($"Entrega expressa iniciada. Tempo estimado: {TempoEstimadoHoras} horas.");
        }
    }
}
