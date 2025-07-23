using System;
using ServicoEntrega;

class Program
{
    static void Main(string[] args)
    {
        EntregaExpresso entregaRapida = new EntregaExpresso(
            "Entrega Rápida", 
            "Rua A, 100", 
            "Rua B, 200", 
            2
        );
        entregaRapida.RealizarServico();
        entregaRapida.FinalizarEntrega();

        Console.WriteLine();

        EntregaEconomica entregaBarata = new EntregaEconomica(
            "Entrega Barata", 
            "Rua C, 50", 
            "Rua D, 300"
        );
        entregaBarata.RealizarServico();
        entregaBarata.FinalizarEntrega();

        Console.WriteLine();

        Entrega entregaNormal = new Entrega(
            "Entrega Normal",
            "Rua E, 10",
            "Rua F, 20"
        );
        entregaNormal.RealizarServico();
        entregaNormal.FinalizarEntrega();

        Console.ReadKey();
    }
}
