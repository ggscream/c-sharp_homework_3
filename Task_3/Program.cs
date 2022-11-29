//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static System.Console;

WriteLine("Введите число N: ");
double N = Convert.ToDouble(ReadLine());

for (int i = 1; i <= N; i++)
{
    double cube = Math.Pow(i, 3);
    WriteLine($"{i} ^ 3 = {cube}");
}
