// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// // 23432 -> да

Console.Write("Enter a 5-digit number: ");
int N = int.Parse(Console.ReadLine());

int a1 = N / 10000;
int a2 = N / 1000 % 10;
int a4 = N / 10 % 10;
int a5 = N % 10;

if (N > 9999 && N < 100000 || N < -9999 && N > -100000)
{
    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine($"YES, the number is palindrome: {a1} = {a5}, {a2} = {a4}");
    }
    else
    {
        Console.WriteLine("NO, the number is NO palindrome:");
    }
}
else
{
    Console.WriteLine("ERROR!");
}


