int N = 20;
tipo_contato[] vetSemTrat = new tipo_contato[N];
tipo_contato[] vetTratLinear = new tipo_contato[N];
tipo_contato[] vetListaEncad = new tipo_contato[N];
int op_princ = Menu();
int sub_op;
while(true){
    if (op_princ == 1){
        Console.WriteLine("\nSEM TRATAMENTO DE COLISÃO!");
        sub_op = subMenu();
        while(true){
            if (sub_op == 1){
                Console.WriteLine("\n******INSERIR******");
                Console.WriteLine("\nInforme a idade do contato: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o nome do contato: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o WhatsApp do contato: ");
                int wpp = Convert.ToInt32(Console.ReadLine());
                InserirSemTrat(ref vetSemTrat, idade, nome, wpp);
            }
            else if (sub_op == 2){
                Console.WriteLine("\n******ALTERAR******");       
                Console.WriteLine("Informe a idade do contato que deseja alterar: ");
                int idade_proc = Convert.ToInt32(Console.ReadLine());
                Alterar(ref vetSemTrat, idade_proc);  
            }
            else if (sub_op == 3){
                Console.WriteLine("\n******VISUALIZAR******");
                Exibir(vetSemTrat);
            }
            else if (sub_op == 4){
                break;
            }
            else
                Console.WriteLine("Infomre uma opção valida!");
            Console.WriteLine("\nPressione alguma tecla para continuar!");
            Console.ReadKey();
            sub_op = subMenu();
        }     
    }
    else if (op_princ == 2){
        Console.WriteLine("\nTRATAMENTO DE COLISÃO LINEAR!");
        sub_op = subMenu();
        while(true){
            if (sub_op == 1){
                Console.WriteLine("\n******INSERIR******");
                Console.WriteLine("\nInforme a idade do contato: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o nome do contato: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o WhatsApp do contato: ");
                int wpp = Convert.ToInt32(Console.ReadLine());
                InserirTratLinear(ref vetTratLinear, idade, nome, wpp);
            }
            else if (sub_op == 2){
                Console.WriteLine("\n******ALTERAR******");       
                Console.WriteLine("Informe a idade do contato que deseja alterar: ");
                int idade_proc = Convert.ToInt32(Console.ReadLine());
                Alterar(ref vetTratLinear, idade_proc);         
            }
            else if (sub_op == 3){
                Console.WriteLine("\n******VISUALIZAR******");
                Exibir(vetTratLinear);     
            }
            else if (sub_op == 4){
                break;
            }
            else
                Console.WriteLine("Infomre uma opção valida!");
            Console.WriteLine("\nPressione alguma tecla para continuar!");
            Console.ReadKey();
            sub_op = subMenu();
        }   
    }
    else if (op_princ == 3){
        Console.WriteLine("\nTRATAMENTO DE COLISÃO LISTA ENCADEADA!");
        sub_op = subMenu();
        while(true){
            if (sub_op == 1){
                Console.WriteLine("\n******INSERIR******");
                Console.WriteLine("\nInforme a idade do contato: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o nome do contato: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o WhatsApp do contato: ");
                int wpp = Convert.ToInt32(Console.ReadLine());
                InserirListaEncad(ref vetListaEncad, idade, nome, wpp);
            }
            else if (sub_op == 2){
                Console.WriteLine("\n******ALTERAR******");  
                //NÃO CONSEGUI FAZER
            }
            else if (sub_op == 3){
                Console.WriteLine("\n******VISUALIZAR******");
                //NÃO CONSEGUI FAZER
            }
            else if (sub_op == 4){
                break;
            }
            else
                Console.WriteLine("Infomre uma opção valida!");
            Console.WriteLine("\nPressione alguma tecla para continuar!");
            Console.ReadKey();
            sub_op = subMenu();
        }   
    }
    else if (op_princ == 4)
        break;
    else
        Console.WriteLine("\nInforme uma opção valida!");
    Console.WriteLine("\nPressione alguma tecla para continuar!");
    Console.ReadKey();
    op_princ = Menu();
}

void InserirSemTrat(ref tipo_contato[] vet, int idade, string nome, int whats){
    int pos = Hash(idade);
    vet[pos] = new tipo_contato();
    vet[pos].idade = idade;
    vet[pos].nome = nome;
    vet[pos].wpp = whats;
    Console.WriteLine("\nInserido com sucesso!");
}

void InserirTratLinear(ref tipo_contato[] vet, int idade, string nome, int whats){
    int qtde = 0;
    int pos = Hash(idade);
    while(vet[pos] != null && qtde < N){
        pos++;
        pos = pos % N;
        qtde++;
    }
    if (vet[pos] == null){
        vet[pos] = new tipo_contato();
        vet[pos].idade = idade;
        vet[pos].nome = nome;
        vet[pos].wpp = whats;
        Console.WriteLine("\nContato inserido com sucesso!");
    }
    else 
        Console.WriteLine("\nImpossivel inserir, vetor cheio!");
}

void Alterar(ref tipo_contato[] vet, int idade){
    int pos = Buscar(vet, idade);
    if (pos != -1){
        Console.WriteLine("\nDados atuais do contato: ");
        Console.WriteLine("Idade " + vet[pos].idade);
        Console.WriteLine("Nome " + vet[pos].nome);
        Console.WriteLine("WhatsApp " + vet[pos].wpp);
        
        Console.WriteLine("\nInforme um novo nome: ");
        string novo_nome = Console.ReadLine();
        Console.WriteLine("Informe um novo WhatsApp: ");
        int novo_wpp = Convert.ToInt32(Console.ReadLine());
        vet[pos].nome = novo_nome;
        vet[pos].wpp = novo_wpp;
        Console.WriteLine("\nContato alterado com sucesso!");
    }
    else
        Console.WriteLine("\nFalha ao alterar, contato não encontrado!");
}

int Buscar(tipo_contato[] vet, int idade){
    int pos = Hash(idade);
    while(vet[pos] == null || vet[pos].idade != idade){
        pos++;
        pos = pos % N;
    }
    if (vet[pos].idade == idade){
        Console.WriteLine("\nContato encontrada!");
        return pos;
    }
    else
        return -1;
}

void Exibir(tipo_contato[] vet){
    Console.WriteLine("\nExibindo dados: ");
    foreach (tipo_contato contato in vet){
        Console.WriteLine("\nIdade: " + contato.idade);
        Console.WriteLine("Nome: " + contato.nome);
        Console.WriteLine("WhatsApp: " + contato.wpp);
    }
}

void InserirListaEncad(ref tipo_contato[] vet, int idade, string nome, int wpp)
{
   tipo_contato no = new tipo_contato();
   no.idade = idade;
   no.nome = nome;
   no.wpp = wpp;
   int pos = Hash(idade);
   if (vet[pos] != null)
      no.prox = vet[pos];
   vet[pos] = no;
   Console.WriteLine("\nContato inserido com sucesso!");
}

int Hash(int chave)
{
   return (chave % N);
}

int Menu(){
    Console.WriteLine("\n******MENU PRINCIPAL DO SISTEMA******");
    Console.WriteLine("1. Sem tratamento de colisão.");
    Console.WriteLine("2. Tratamento de colisão linear.");
    Console.WriteLine("3. Tratamento de colisão lista encadeada."); 
    Console.WriteLine("4. Sair."); 
    Console.WriteLine("\nInforme a opção desejada: ");
    op_princ = Convert.ToInt32(Console.ReadLine());
    return op_princ;
}

int subMenu(){
    Console.WriteLine("\n******MENU SECUNDÁRIO DO SISTEMA******");
    Console.WriteLine("1. Inserir.");
    Console.WriteLine("2. Alterar.");
    Console.WriteLine("3. Relatar."); 
    Console.WriteLine("4. Sair para menu principal."); 
    Console.WriteLine("\nInforme a opção desejada: ");
    sub_op = Convert.ToInt32(Console.ReadLine());
    return sub_op;
}

class tipo_contato
{
    public int idade, wpp;
    public string nome;
    public tipo_contato prox;
}