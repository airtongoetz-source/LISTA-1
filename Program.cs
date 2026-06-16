Console.Write("Informe a primeira pontuação: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Informe a segunda pontuação: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Informe a terceira pontuação: ");
int n3 = int.Parse(Console.ReadLine());

if (n1 == n2 && n2 == n3)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else
{
    int maior = n1;

    if (n2 > maior)
    {
        maior = n2;
    }

    if (n3 > maior)
    {
        maior = n3;
    }

    Console.WriteLine($"Maior pontuação: {maior}");
}