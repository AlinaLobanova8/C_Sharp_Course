// See https://aka.ms/new-console-template for more information

int Num(int num)
{
    return num % 10;
}

Console.WriteLine(Num(new Random().Next(100, 1000)));