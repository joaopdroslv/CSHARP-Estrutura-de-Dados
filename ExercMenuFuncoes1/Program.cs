int op = 0, op2 = 0;
while(op != 3)
{
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL.");
    Console.WriteLine("1. Funções sem vetor.");
    Console.WriteLine("2. Funções com vetor.");
    Console.WriteLine("3. Sair.");
    Console.WriteLine("Digite a opção desejada: .");
    op = Convert.ToInt32(Console.ReadLine());
    if(op == 1)
    {
        int nI, nF;
        Console.WriteLine("Digite o número inicial: ");
        nI = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número final: ");
        nF = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("MENU 2.");
        Console.WriteLine("1. Crescente.");
        Console.WriteLine("2. Decrescente.");
        Console.WriteLine("3. Impares.");
        Console.WriteLine("4. Somatória.");
        Console.WriteLine("Digite a opção desejada: .");
        op2 = Convert.ToInt32(Console.ReadLine());
        if (op2 == 1)
        { 
            crescente(nI, nF);
        }
        else if (op2 == 2)
        {
            decrescente(nI, nF);
        }
        else if (op2 == 3)
        {
            impares(nI, nF);
        }
        else if (op2 == 4)
        {
            int s = somatoria(nI, nF);
            Console.WriteLine("Soma = " + s);
        }
    }
    else if(op == 2)
    {
        int[] vetor = new int[5];
        int i = 0, n = 1;
        while(n != 0)
        {
            Console.WriteLine("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            vetor[i] = n;
            i = i + 1;
        }
        //int s = somaVetor(vetor, i);
        //Console.WriteLine(s);
    }
    Console.ReadKey();
}

void crescente(int nI, int nF)
{
    if(nI <= nF)
    {
        Console.WriteLine(nI);
        crescente(nI + 1, nF);
    }
}

void decrescente(int nI, int nF)
{
    if(nF >= nI)
    {
        Console.WriteLine(nF);
        decrescente(nI, nF - 1);
    }
}

void impares(int nI, int nF)
{
    if(nI <= nF)
    {
        if(nI % 2 != 0)
        {
            Console.WriteLine(nI);
        }
        impares(nI + 1, nF);
    }
}

int somatoria(int nI, int nF)
{
    if(nI < nF)
    {
        return nI + somatoria(nI + 1, nF);
    }
    else
    {
        return nI;
    }
}