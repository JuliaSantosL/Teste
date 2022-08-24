int n = 0;
int total = 0;
Console.WriteLine("Digite um número, e depois pressione Enter: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    if (i % 3 == 0)
    {
        total += i;
    }
    if (i % 5 == 0)
    {
            total += i;
    }
}
Console.WriteLine("A Soma dos múltiplos de 3 e 5 é igual a {0}\n", total);