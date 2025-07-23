namespace ServicoEntrega
{
    public abstract class Servico
    {
        public string Nome { get; set; }

        public Servico(string nome)
        {
            Nome = nome;
        }

        public abstract void RealizarServico();
    }
}
