tp_no lista = null;

int op = menu();
while(true)
{
    if (op == 1)
    {
        Console.WriteLine("\nInforme um elemento para ser inserido: ");
        int elemn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nInserindo elemento {elemn}");
        Inserir(ref lista, elemn);
    }
    else if (op == 2)
    {
        if (lista != null)
        {
            tp_no rmv = Remover(ref lista);
            Console.WriteLine($"\nO seguinte número foi removido: {rmv.valor}"); 
        }
        else
            Console.WriteLine($"\nLista Vazia!");
    }
    else if (op == 3)
        break;
    else
        Console.WriteLine("Informe uma opção valida.");

    Console.ReadKey();
    Console.Clear();
    op = menu();
}

void Inserir(ref tp_no lista, int valor)
{
    tp_no no = new tp_no();
    no.valor = valor;
    if (lista != null)
        no.prox = lista;
    lista = no;
}

tp_no Remover(ref tp_no lista)
{
    tp_no no = null;
    if (lista != null)
    {
        no = lista;
        lista = lista.prox;
        no.prox = null;
    }
    return no;
}

int menu()
{
    Console.WriteLine("\nMENU DO SISTEMA.");
    Console.WriteLine("1. INSERIR ELEMENTO.");
    Console.WriteLine("2. REMOVER ELEMENTO.");
    Console.WriteLine("3. SAIR.");
    Console.WriteLine("\nInforme a opção desejada: ");
    int op = Convert.ToInt32(Console.ReadLine());
    return op;
}

class tp_no
{
    public int valor;
    public tp_no prox;
}
