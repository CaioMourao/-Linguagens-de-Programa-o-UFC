using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

class VerificadorDeSenhas
{
    static List<string> senhas = new List<string>();
    static object lockObj = new object();

    static void Main()
    {
        // Gerar senhas fictícias
        for (int i = 0; i < 100; i++)
        {
            senhas.Add("Senha123!");
            senhas.Add("fraca");
            senhas.Add("12345678");
            senhas.Add("Boa#Senha99");
        }

        Console.WriteLine($"Total de senhas: {senhas.Count}\\n");

        // Execução sequencial
        Stopwatch swSeq = Stopwatch.StartNew();
        foreach (var senha in senhas)
        {
            VerificarSenha(senha);
        }
        swSeq.Stop();
        Console.WriteLine($"Tempo (Sequencial): {swSeq.ElapsedMilliseconds}ms");

        // Execução concorrente
        Stopwatch swConc = Stopwatch.StartNew();
        int numThreads = 8;
        int senhasPorThread = senhas.Count / numThreads;
        List<Thread> threads = new List<Thread>();

        for (int i = 0; i < numThreads; i++)
        {
            int inicio = i * senhasPorThread;
            int fim = (i == numThreads - 1) ? senhas.Count : inicio + senhasPorThread;
            var thread = new Thread(() => ProcessarLote(inicio, fim));
            threads.Add(thread);
            thread.Start();
        }

        foreach (var t in threads)
        {
            t.Join();
        }

        swConc.Stop();
        Console.WriteLine($"Tempo (Concorrente): {swConc.ElapsedMilliseconds}ms");
    }

    static void ProcessarLote(int inicio, int fim)
    {
        for (int i = inicio; i < fim; i++)
        {
            VerificarSenha(senhas[i]);
        }
    }

    static void VerificarSenha(string senha)
    {
        Thread.Sleep(10);

        bool tamanhoOK = senha.Length >= 8;
        bool temNumero = Regex.IsMatch(senha, @"\\d");
        bool temLetra = Regex.IsMatch(senha, @"[a-zA-Z]");
        bool temSimbolo = Regex.IsMatch(senha, @"[!@#$%^&*(),.?\"{}|<>]");

        bool valida = tamanhoOK && temNumero && temLetra && temSimbolo;

        lock (lockObj)
        {
        }
    }
}