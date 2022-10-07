// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter a number: ");
int N = int.Parse(Console.ReadLine());


Console.WriteLine($"For {N} the 3rd extent values of previous numbers are:");

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}
if (N < 0)
{
    for (int i = N; i < 0; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}
if (N == 0) Console.WriteLine(0);
