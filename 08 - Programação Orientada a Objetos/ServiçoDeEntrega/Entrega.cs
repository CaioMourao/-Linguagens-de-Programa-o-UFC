using System;

namespace ServicoEntrega
{
    public class Entrega : Servico
    {
        public string EnderecoOrigem { get; set; }
        public string EnderecoDestino { get; set; }
        public string Status { get; protected set; }

        public Entrega(string nome, string enderecoOrigem, string enderecoDestino) 
            : base(nome)
        {
            EnderecoOrigem = enderecoOrigem;
            EnderecoDestino = enderecoDestino;
            Status = "Pendente";
        }

        public override void RealizarServico()
        {
            Status = "Em andamento";
            Console.WriteLine($"Iniciando entrega de {EnderecoOrigem} para {EnderecoDestino}.");
        }

        public void FinalizarEntrega()
        {
            Status = "Concluída";
            Console.WriteLine("Entrega concluída.");
        }
    }
}
