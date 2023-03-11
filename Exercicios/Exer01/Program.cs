void Crescente(int NumeroInicial, int NumeroFinal)
{
    if (NumeroInicial <= NumeroFinal)
    {
        Console.WriteLine(NumeroInicial);
        Crescente(NumeroInicial + 1, NumeroFinal);
    }
}
void Decrescente (int NumeroInicial, int NumeroFinal)
{
    if (NumeroInicial <= NumeroFinal)
    {
        Decrescente(NumeroInicial + 1, NumeroFinal);
        Console.WriteLine(NumeroInicial);
    }
}
void Impares (int NumeroInicial, int NumeroFinal)
{
    if (NumeroInicial <= NumeroFinal)
    {
        if (NumeroInicial % 2 != 0)
            Console.WriteLine(NumeroInicial);
            Impares(NumeroInicial + 1, NumeroFinal);
    }
}
int SomaRecursiva(int NumeroInicial, int NumeroFinal)
{
    if (NumeroInicial < NumeroFinal)
    {
        return SomaRecursiva (NumeroInicial + 1, NumeroFinal) + NumeroInicial;
    }
    else return NumeroInicial;
}

string op1 = "0";

while (op1 != "3")
{
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Funções sem vetor");
    Console.WriteLine("2 - Funções com vetor");
    Console.WriteLine("3 - Sair");
    Console.Write("Digite a opção desejada: ");
    op1 = Console.ReadLine();

    if (op1 == "1")
    {
        Console.Write("Número Inicial: ");
        int NumInicial;
        NumInicial = Convert.ToInt32(Console.ReadLine());
        Console.Write("Número Final: ");
        int NumFinal;
        NumFinal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("MENU SECUNDÁRIO");
        Console.WriteLine("1 - Inteiros crescente");
        Console.WriteLine("2 - Inteiros decrescente");
        Console.WriteLine("3 - Inteiros Ímpares");
        Console.WriteLine("4 - Somatório");
        Console.WriteLine("4 - Voltar");
        Console.Write("Digite a opção desejada: ");
        string op2 = Console.ReadLine();

        if (op2 == "1")
        {
            Crescente (NumInicial, NumFinal);
        }
        else if (op2 == "2")
        {
            Decrescente (NumInicial, NumFinal);
        }
        else if (op2 == "3")
        {
            Impares (NumInicial, NumFinal);
        }
        else if (op2 == "4")
        {
            int Somatorio;
            Somatorio = SomaRecursiva(NumInicial, NumFinal);
            Console.WriteLine(Somatorio);
        }
    }
    else if (op1 == "2")
    {
        int [] vetor;
        vetor = new int [10];
        int i = 0, numero = 1;
        while (numero != 0)
        {
            i +=1;
            Console.WriteLine("Insira o número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            vetor[i] = numero;
        }
        System.Console.WriteLine(SomaVetorRecursiva(vetor, 1, i));
    }
    int SomaVetorRecursiva(int [] vetor, int NumInicial, int NumFinal)
    {
        if (NumInicial < NumFinal)
        {
            return SomaVetorRecursiva(vetor, NumInicial + 1, NumFinal) + vetor[NumInicial];
        }else
            return vetor[NumInicial];
    }

    Console.ReadKey();
}