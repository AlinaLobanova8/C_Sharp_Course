// See https://aka.ms/new-console-template for more information

void Chet(int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i += 1;
        if (i == (N))
        {
            pere = Math.Pow(i,2);
            Console.Write($"{pere}");
        }

        pere = Math.Pow(i,2);
        Console.Write($"{pere},");
    }


}
Console.WriteLine("Введите x: ");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);
