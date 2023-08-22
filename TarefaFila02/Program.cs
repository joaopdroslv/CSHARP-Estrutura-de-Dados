/*
15) Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. 
Os aviões são identificados pelos números digitados pelo usuário. 
Neste programa, o usuário deve ser capaz de realizar as seguintes operações:

a) Adicionar vários aviões à fila de espera para decolagem

b) Consultar a quantidade de aviões aguardando na fila

c) Autorizar a decolagem de um avião da fila

d) Listar os números de todos os aviões na fila

e) Consultar o número do primeiro avião da fila

Construa um menu principal para oferecer essas operações ao usuário.
*/

const int max = 20;
int [] fila = new int [max];
int inicio = 0, fim = 0;
int op, numero;

op = Menu();
while(true)
{
    Console.WriteLine("\n");
    Console.WriteLine($" OPÇÃO SELECIONADA: {op}\n");
    if(op == 1)
    {
        Console.WriteLine("Adicionar varios aviões à fila de espera para decolagem.");
        while(true)
        {
            Console.WriteLine("Digite um nº de avião(digite 0 para sair): ");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero == 0)
                break;
            else if (EstaCheia(fim) == false)
                Inserir(fila, ref fim, numero);
            else
            {
                Console.WriteLine("\nFila está cheia.");
                break;
            }
        }
    }
    else if(op >= 2 && op <= 5)
    {
        if (EstaVazia(inicio, fim) == false)
        {
            if(op == 2)
            {
                Console.WriteLine("Consultar a quantidade de aviões aguardando na fila.");
                Console.WriteLine($" A quantidade de aviões em espera é: {ContarFila(fila, inicio, fim)}");
            }
            else if(op == 3)
            {
                Console.WriteLine("Autorizar a decolagem de um avião da fila.");
                Console.WriteLine($"O avião de número {Remover(fila, ref inicio)} foi autorizado a decolar, saiu da fila.");
            }
            else if(op == 4)
            {
                Console.WriteLine("Listar os números de todos os aviões na fila.");
                Console.WriteLine("Números dos aviões: ");
                ListarFila(fila, inicio, fim);
            }
            else if(op == 5)
            {
                Console.WriteLine("Consultar o número do primeiro avião da fila.");
                Console.WriteLine($"O número do primeiro avião é {ConsultarPrimeiro(fila, inicio)}");
            }
        }
        else
        {
        Console.WriteLine("Opção indisponivel, a fila esta vazia.");
        Console.WriteLine("     Adicione ao menos um avião na fila para usa-lá.");
        }
    }
    else if(op == 6)
    {
        Console.WriteLine("Sair do sistema.");
        break;
    }
    else
        Console.WriteLine("Opção invalida, digite uma opção valida.");
    Console.ReadKey();
    op = Menu();
}

void Inserir(int[] fila, ref int fim, int num)
{
    fila[fim] = num;
    fim += 1;
}

int Remover(int[] fila, ref int inicio)
{
    int num = fila[inicio];
    inicio += 1;
    return (num);
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

int ContarFila(int[] fila, int inicio, int fim)
{
    int qtde = 0;
    for(int i = inicio; i < fim; i++)
    {
        qtde += 1;
    }
    return qtde;
}

void ListarFila(int[] fila, int inicio, int fim)
{
    for(int i = inicio; i < fim; i++)
    {
        Console.WriteLine("Avião nº " + fila[i]);
    }
}

int ConsultarPrimeiro(int[] fila, int inicio)
{
    int primeiro = fila[inicio];
    return primeiro;
}

int Menu()
{
    Console.Clear();
    Console.WriteLine("\n********************* MENU DO SISTEMA **********************");
    Console.WriteLine("1 - Adicionar varios aviões à fila de espera para decolagem.");
    Console.WriteLine("2 - Consultar a quantidade de aviões aguardando na fila.");
    Console.WriteLine("3 - Autorizar a decolagem de um avião da fila.");
    Console.WriteLine("4 - Listar os números de todos os aviões da fila.");
    Console.WriteLine("5 - Consultar o número do primeiro avião da fila.");
    Console.WriteLine("6 - Para sair");
    Console.WriteLine("Informe a opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    return op;
}