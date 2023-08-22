/*
Enquanto não fim da frase(frase.lenght)
    Enquanto não for fim da palavra(frase[i] != "")
        Insere(pilha,...,...)
        i++

    Enquanto a pilha não esta vazia
        c = remove(...)
        Console.WriteLine(c)
    Console.WriteLine("")
    i += 1
*/

const int max = 20;
char[] pilha = new char[max];
int topo = 0;
int i = 0;

Console.WriteLine("*********************************************");
Console.WriteLine("PROGRAMA QUE INVERTE AS PALAVRAS DE UM FRASE.");
Console.WriteLine("Informe a frase que deseja inverter: ");
string frase = Console.ReadLine();

while(i < frase.Length)
{
    //enquanto não for fim da plavra
    while(i < frase.Length && frase[i] != ' ')
    {
        //inserir a letra na pilha
        Inserir(pilha, ref topo, frase[i]);
        i++;
    }
    //enquanto frase não acabar
    while(EstaVazia(topo) == false)
    {
        //remover a letra da pilha
        char letra = Remover(pilha, ref topo);
        //exibir a letra removida da pilha
        Console.WriteLine(letra);
    }
    i++;
    Console.WriteLine("");
}

void Inserir(char[] pilha, ref int topo, char letra)
{
    //inserir letra no topo da pilha
    pilha[topo] = letra;
    //aumentar o valor do topo
    topo += 1;
}

char Remover(char[] pilha, ref int topo)
{
    //decrementar o valor do topo
    topo -= 1;
    //retornar a letra que esta no topo da pilha
    return(pilha[topo]);
}

bool EstaVazia(int topo)
{
    if(topo == 0)
        return true;
    else
        return false;
}