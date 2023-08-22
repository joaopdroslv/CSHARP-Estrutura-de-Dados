using System;
using System.Threading;

Console.Clear();
Console.WriteLine("****PROGRAMA PARA CALCULAR FATORIAL COM THREADS****");
Console.Write("Quantos calcúlos deseja realizar: ");
int num = 0;
int nc;
string nome = "";
nc = Convert.ToInt32(Console.ReadLine());
Thread t;
int[] thread = new int[nc];
Console.WriteLine("\n");
for (int i = 0; i < nc; i++)
{
    Console.Write($"Digite o {i + 1} º número a ter o fatorial calculado: ");
    num = Convert.ToInt32(Console.ReadLine());
    thread[i] = num;
}
for (int j = 0; j < thread.Length; j++)
{
    num = thread[j];
    nome = "Thread_" + (j + 1);
    t = new Thread(NovaThread);
    t.Start();
    Thread.Sleep(2000);
}

void NovaThread()
{
    fatorial(num, nome);
}

void fatorial(int num, string nome)
{
    Console.WriteLine("\n************************************************************");
    Console.WriteLine($"{nome} iniciou.");
    int reslt = 1;
    if (num == 0)
    {
        reslt = 0;
    }
    else
    {
        for (int k = 1; k <= num; k++)
        {
            reslt = reslt * k;
            Console.Write($"{nome} | fat de {num} | cálculo iteração: ");
            Console.WriteLine($"{k} * {reslt/k} = {reslt}");
        }
        Console.WriteLine($"{nome} | O fatorial de {num} é {reslt}");
        Thread.Sleep(3000);
    }
}