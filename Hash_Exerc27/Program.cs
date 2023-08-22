const int N = 5;
tp_no[] vetor = new tp_no[N];
int qtdeC = 0;

int op = menu();
while (true){
    Console.WriteLine("\nOpção selecionada: ");
    if (op == 1){
        Console.WriteLine("********Inserir********");
        Console.WriteLine("Informe a nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe o e-mail: ");
        string email = Console.ReadLine();
        InserirLinear(vetor, nota, nome, email, ref qtdeC);
    }
    else if (op == 2){
        Console.WriteLine("********Recuperar********");
        Console.WriteLine("Informe a nota que deseja buscar: ");
        int notaBusca = Convert.ToInt32(Console.ReadLine());
        ExibirDados(vetor, notaBusca);
    }
    else if (op == 3){
        Console.WriteLine("********Informar********");
        Console.WriteLine("Ocorreram " + qtdeC + " colisões até o momento.");
    }
    else if (op == 4)
        break;
    else
        Console.WriteLine("\nInforme uma opção válida.");

    Console.WriteLine("\nPressione uma tecla para continuar.");
    Console.ReadKey();
    op = menu();
}


void InserirLinear(tp_no[] vet, int nt, string nome, string email, ref int qtC){
    int pos = Hash(nt);
    while(vet[pos] != null){
        pos++;
        pos = pos % N;
        qtC++;
    }
    vet[pos] = new tp_no();
    vet[pos].nota = nt;
    vet[pos].nome = nome;
    vet[pos].email = email;

    Console.WriteLine("\nInserido com sucesso.");
}

void ExibirDados(tp_no[] vet, int nt){
    int pos = BuscarLinear(vet, nt);
    if (pos != -1){
        Console.WriteLine("\nNota encontrada.");
        Console.WriteLine("\nExibindo: \n");
        Console.WriteLine("Nota: " + vet[pos].nota);
        Console.WriteLine("Nome: " + vet[pos].nome);
        Console.WriteLine("E-mail: " + vet[pos].email);
    }
    else
        Console.WriteLine("\nFalha na busca. Nota não encontrada.");
}

int BuscarLinear(tp_no[] vet, int nt){
    int pos = Hash(nt);
    while(vet[pos] == null || vet[pos].nota != nt && qtdeC < N){
        pos++;
        pos = pos % N;
    }
    if (qtdeC < N)
        return pos; 
    else
        return -1;
}

int Hash(int chave)
{
   return (chave % N);
}


int menu(){
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine("****MENU DO SISTEMA****");
    Console.WriteLine("1 - Inserir.");
    Console.WriteLine("2 - Recuperar.");
    Console.WriteLine("3 - Informar.");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("\nInforme a opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    return op;
}
class tp_no{
    public int nota;
    public string nome, email;
}