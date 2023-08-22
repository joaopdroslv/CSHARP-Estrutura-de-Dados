int max = 20;
int [] fila = new int [max];
int inicio = 0, fim = 0;
int [] filaMa = new int [max];
int inicioMa = 0, fimMa = 0;
int [] filaMe = new int [max];
int inicioMe = 0, fimMe = 0;
int v, vd;
v = 1;
while(v != 0)
{
    Console.WriteLine("Digite um valor: ");
    v = Convert.ToInt32(Console.ReadLine());
    if (EstaCheia(fim) == false)
        Inserir(fila, ref fim, v);
    else
    {
        Console.WriteLine("Fila cheia.");
        v = 0;
    }
}
Console.WriteLine("Digite o valor do divisor: ");
vd = Convert.ToInt32(Console.ReadLine());
while(!EstaVazia(inicio, fim))
{
    v = Remover(fila, ref inicio);
    if (v >= vd)
        Inserir(filaMa, ref fimMa, v);
    else
        Inserir(filaMe, ref fimMe, v);
}
Console.WriteLine("Fila com números maiores que " + vd);
while(!EstaVazia(inicioMa, fimMa))
    Console.WriteLine(Remover(filaMa, ref inicioMa));
Console.WriteLine("Fila com números menores que " + vd);
while(!EstaVazia(inicioMe, fimMe))
    Console.WriteLine(Remover(filaMe, ref inicioMe));

void Inserir(int[] fila, ref int fim, int valor)
{
    fila[fim] = valor;
    fim = fim + 1;
}

int Remover(int[] fila, ref int i)
{
    int v = fila[i];
    i = i + 1;
    return (v);
}

bool EstaVazia(int inicio, int fim)
{
    if (inicio == fim)
        return true;
    else
        return false;
}

bool EstaCheia(int fim)
{
    if (fim == max)
        return true;
    else
        return false;
}
