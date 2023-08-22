int op = 0;
while (op != 6)
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("****MENU PRINCIPAL****");
    Console.WriteLine("1. Potência.");
    Console.WriteLine("2. Cubo.");
    Console.WriteLine("3. Maximo divisor comum.");
    Console.WriteLine("4. Calcular Fibonacci.");
    Console.WriteLine("5. Converter para binário.");
    Console.WriteLine("\nInforme a opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("*******************************************");
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