// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int N = int.Parse(a);
int NegN = - N;

while (NegN <= N)
{
    Console.Write($"{NegN} ");
    NegN +=1;
}
