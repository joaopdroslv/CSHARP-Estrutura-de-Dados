tp_no raiz = null;
int x, op_tipo;
int op = Menu();

while(true){
    Console.WriteLine("\nOpção selecionada: ");
    if (op == 1){
        Console.WriteLine("****INSERIR****");
        Console.WriteLine("\nInforme o valor á ser inserido na árvore: ");
        x = Convert.ToInt32(Console.ReadLine());
        Inserir(ref raiz, x);
        Console.WriteLine("\nValor inserido com sucesso.");
    }
    else if (op == 2){
        Console.WriteLine("****PESQUISAR****");
        Console.WriteLine("\nInforme o valor a ser pesquisado: ");
        x = Convert.ToInt32(Console.ReadLine());
        tp_no result = Buscar(raiz, x);
        if (result == null)
            Console.WriteLine("\nValor não encontrado na árvore.");
        else
            Console.WriteLine("\nValor " + result.valor + " foi encontrado na árvore.");
    }
    else if (op == 3){
        Console.WriteLine("****REMOVER****");
        Console.WriteLine("\nInforme o valor á ser removido da árvore: ");
        x = Convert.ToInt32(Console.ReadLine());
        tp_no result = Remover(ref raiz, x);
        if (result == null){
            Console.WriteLine("\nFalha na remoção.");
            Console.WriteLine("Valor não encontrado na árvore.");
        }
        else
            Console.WriteLine("\nValor " + result.valor + " foi removido da árvore.");
    }
    else if (op == 4){
        Console.WriteLine("****EXIBIR****"); 
        if (raiz != null){
            op_tipo = MenuTipo();
            Console.WriteLine("\nTipo de exibição: ");
            if (op_tipo == 1){
                Console.WriteLine("****Em ordem****\n");
                EmOrdem(raiz);
            }
            else if (op_tipo == 2){
                Console.WriteLine("****Pré ordem****\n");
                PreOrdem(raiz);
            }
            else if (op_tipo == 3){
                Console.WriteLine("****Pós ordem****\n");
                PosOrdem(raiz);
            }
            else
                Console.WriteLine("\nA opção informada é inválida.");
            }
        else
            Console.WriteLine("\nA árvore binária está vazia.");
    }
    else if (op == 5){
        Console.WriteLine("\nSaindo...");
        break;
    }
    else
        Console.WriteLine("\nA opção informada é inválida.");
    Console.WriteLine("\nPressione alguma tecla para continuar.");
    Console.ReadKey();
    op = Menu();
}

void Inserir(ref tp_no r, int x)
{
   if (r == null)
   {
      r = new tp_no();
      r.valor = x;
   }
   else if (x < r.valor)
      Inserir(ref r.esq, x);
   else
      Inserir(ref r.dir, x);
}


tp_no Buscar(tp_no r, int x)
{
   if (r == null)
      return null;
   else if (x == r.valor)
      return r;
   else if (x < r.valor)
      return Buscar(r.esq, x);
   else
      return Buscar(r.dir, x);
}

tp_no Remover(ref tp_no r, int x)
{
   if (r == null)
      return null;     
   else if (x == r.valor)
   {       
      tp_no p = r;
      if (r.esq == null) //Não tem filho na esquerda
         r = r.dir;
      else if (r.dir == null) //Não tem filho na direita
         r = r.esq;
      else //Tem ambos os filhos
      {
         p = RetornarMaior(ref r.esq);
         r.valor = p.valor;
      }
      return p;
   }
   else if (x < r.valor)
      return Remover(ref r.esq, x);
   else
      return Remover(ref r.dir, x);
}

tp_no RetornarMaior(ref tp_no r)
{
   if (r.dir == null)
   {
      tp_no p = r;
      r = r.esq;
      return p;
   }
   else
      return RetornarMaior(ref r.dir);
}

void EmOrdem(tp_no r)
{
    if (r != null){
        EmOrdem(r.esq);
        Console.WriteLine(r.valor);
        EmOrdem(r.dir);
    }
}

void PreOrdem(tp_no r)
{
    if (r != null){
        Console.WriteLine(r.valor);
        PreOrdem(r.esq);
        PreOrdem(r.dir);
    }
}

void PosOrdem(tp_no r)
{
    if (r != null){
        PosOrdem(r.esq);
        PosOrdem(r.dir);
        Console.WriteLine(r.valor);
    }
}

int MenuTipo(){
    Console.WriteLine("\n********TIPO DE EXIBIÇÃO********");
    Console.WriteLine("1 - Em ordem.");
    Console.WriteLine("2 - Em pré ordem.");
    Console.WriteLine("3 - Em pós ordem.");
    Console.WriteLine("\nInforme o tipo de exibição desejada: ");
    op_tipo = Convert.ToInt32(Console.ReadLine());
    return op_tipo;
}

int Menu(){
    Console.WriteLine("\n********MENU DO SISTEMA********");
    Console.WriteLine("1 - Inserir na árvore.");
    Console.WriteLine("2 - Buscar da árvore.");
    Console.WriteLine("3 - Remover da árvore.");
    Console.WriteLine("4 - Exibir da árvore.");
    Console.WriteLine("5 - Sair.");
    Console.WriteLine("\nInforme a opção desejado: ");
    op = Convert.ToInt32(Console.ReadLine());
    return op;
}
class tp_no
{
   public tp_no esq;
   public int valor;
   public tp_no dir;
}
