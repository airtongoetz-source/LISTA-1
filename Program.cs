Console.Write("Informe a quantidade de clientes atendidos: ");
int quantidadeClientes = int.Parse(Console.ReadLine());

double tempoTotal = 0;

for (int i = 1; i <= quantidadeClientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    double tempo = double.Parse(Console.ReadLine());

    tempoTotal += tempo;
}

double tempoMedio = tempoTotal / quantidadeClientes;

Console.WriteLine($"Tempo total de atendimento: {tempoTotal} minutos");
Console.WriteLine($"Tempo médio por cliente: {tempoMedio} minutos");