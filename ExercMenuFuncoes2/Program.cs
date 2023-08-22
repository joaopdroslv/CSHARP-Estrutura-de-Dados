int op = menu();
while (op > 0 && op <= 6)
{
    if (op == 1)
    {
        int x, y;
        Console.WriteLine("*******Calcular potência.*******");
        Console.WriteLine("Informe X (base): ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe Y (potência): ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O resultado de {x} elevado a {y} é {potencia(x,y)}");
        Console.WriteLine("*******************************************");
    }
    else if (op == 2)
    {
        int n;
        Console.WriteLine("*******Calcular cubo.*******");
        Console.WriteLine("Digite um número: ");
        n = Convert.ToInt32(Console.ReadLine());
        cubo(n);
    }
    else if (op == 3)
    {
        int x, y;
        Console.WriteLine("*******Achar Maximo divisor comum de dois números.*******");
        Console.WriteLine("Informe X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe Y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O MDC de {x} e {y} é {mdc(x,y)}");
    }
    else if (op == 4)
    {
        int x;
        Console.WriteLine("*******Calcular n-ésimo termo da série de Fibonacci.*******");
        Console.WriteLine("Informe um número: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine($"O {x} º termo da série de Fibonacci é {fibonacci(x)}.");
        Console.WriteLine($"Calculando Fibonacci iterativamente {x} vezes: ");
        fibonacciIterativa(x);
    }
    else if (op == 5)
    {
        int x;
        int bin;
        Console.WriteLine("*******Converter decimal para binário.*******");
        Console.Write("informe o numero inteiro para conversão: ");
        x = Convert.ToInt32(Console.ReadLine());
        bin = Convert.ToInt32(binario(x));
        Console.WriteLine($"O número inteiro {x} em binário é {bin}");
    }
    else if (op == 6)
    {
        Console.WriteLine("Fechando o sistema.");
        break;
    }
    Console.ReadKey();
    op = menu();
}

int potencia(int x, int y)
{
    if (y == 0)
    {
        return 1;
    }
    else
    {
        return x * potencia(x, y - 1);
    }
}
void cubo(int n)
{
    if (n >= 1)
    {
        Console.WriteLine($"O cubo de {n} é {n*n} m²");
    }
}
int mdc(int x, int y)
{
    if (x == y)
    {
        return x;
    }
    else if (x > y)
    {
        return mdc(x - y, y);
    }
    else
    {
        return mdc(x, y - x);
    }
}
int fibonacci(int x)
{
    if (x == 0 || x == 1)
    {
        return x;
    }
    else if (x == 2)
    {
        return 1;

    }
    else
    {

        return fibonacci(x - 1) + fibonacci(x - 2);
    }
}
void fibonacciIterativa(int x)
{
    int n1 = 0, n2 = 1, aux;
	for (int i = 0; i​​​​​​​ < x; i++)
	{
		aux = n1;
		n1 = n2;
		n2 = n1 + aux;
        Console.WriteLine(n2);
	}
}
string binario(int n)
{
    if (n >= 1)
    {
        if (n % 2 == 1)
        {
            return "" + binario((n - 1) / 2) + "1";
        }
        else
        {
            n = n / 2;
            return "" + binario(n) + "0";
        }
    }
    return "0";
}
int menu()
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("****MENU PRINCIPAL****");
    Console.WriteLine("1. Potência.");
    Console.WriteLine("2. Cubo.");
    Console.WriteLine("3. Maximo divisor comum.");
    Console.WriteLine("4. Calcular Fibonacci.");
    Console.WriteLine("5. Converter para binário.");
    Console.WriteLine("6. SAIR.");
    Console.WriteLine("\nInforme a opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("*******************************************");
    return op;
}