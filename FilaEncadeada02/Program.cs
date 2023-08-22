tp_no lista = null;

int op = Menu();
while(true)
{
    Console.WriteLine("\nOpção selecionada: ");
    if (op == 1)
    {
        Console.WriteLine("******** Inserir na lista. ********");
        Console.WriteLine("\nInforme o nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe a idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o wpp(sem caracteres especiais): ");
        int wpp = Convert.ToInt32(Console.ReadLine());
        Inserir(ref lista, nome, idade, wpp);
    }
    else if (op == 2)
    {
        Console.WriteLine("******** Exibir todos os registros. ********");  
        Exibir(lista);
    }
    else if (op == 3)
    {
        Console.WriteLine("******** Alterar registro da lista. ********");
    }
    else if (op == 5)
        break;

    else
        Console.WriteLine("Digite uma opção valida.");

    Console.WriteLine("\nPressione alguma tecla para continuar.");
    Console.ReadKey();
    Console.Clear();
    op = Menu();
}

void Inserir(ref tp_no lista, string nome, int idade, int wpp)
{
    tp_no no = new tp_no();
    no.nome = nome;
    no.idade = idade;
    no.wpp = wpp;
    if (lista != null)
        no.prox = lista;
    lista = no;
    Console.WriteLine("\nInserido com sucesso.");
}

void Consultar(tp_no lista, string nome_proc, ref tp_no anterior, ref tp_no atual)
{
    atual = lista;
    anterior = null;
    while(atual != null && nome_proc != atual.nome)
    {
        anterior = atual;
        atual = atual.prox;
    }
}

void Alterar(tp_no lista)
{
    string nome_proc;
    tp_no anterior = null, atual = null;
    Console.WriteLine("\nInforme o nome para consultar: ");
    nome_proc = Console.ReadLine();
    Consultar(lista, nome_proc ,ref anterior, ref atual);
    if (atual != null) //OU SEJA, ENCONTROU
    {
        Console.WriteLine("\nDados atuais: ");
        Console.WriteLine("Nome: " + atual.nome);
        Console.WriteLine("Idade: " + atual.idade);
        Console.WriteLine("Whatsapp: " + atual.wpp);
        Console.WriteLine("\nDigite os novos dados: ");
        Console.WriteLine("Informe o novo nome: ");
        atual.nome = Console.ReadLine();
        Console.WriteLine("Informe a nova idade: ");
        atual.idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o novo Whatsapp: ");
        atual.wpp = Convert.ToInt32(Console.ReadLine());
    }
    else
        Console.WriteLine("Registro não encontrado.");
}

void Exibir(tp_no lista)
{
    tp_no aux = lista;
    while(aux != null)
    {
        Console.WriteLine("Nome" + aux.nome);
        Console.WriteLine("Idade" + aux.idade);
        Console.WriteLine("Whatsapp" + aux.wpp);
    }
}

int Menu()
{
    Console.WriteLine("****** MENU DO SISTEMA ******");
    Console.WriteLine("1. Inserir registro na lista.");
    Console.WriteLine("2. Exibir registros da lista.");
    Console.WriteLine("3. Alterar registro da lista.");
    Console.WriteLine("4. Excluir registro da lista.");
    Console.WriteLine("5. Sair.");
    Console.WriteLine("Informe a opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    return op;
}

class tp_no
{
    public string nome;
    public int idade, wpp;
    public tp_no prox = null;
}