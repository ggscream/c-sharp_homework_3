//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using static System.Console;

bool Palindrome(int number) 
{
    string digit = number.ToString(); 
    for (int i = 0; i < digit.Length; i++) 
        if (digit[i] != digit[digit.Length - 1 - i])                        
            return false;
    return true;
}

WriteLine("Введите пятизначное число: ");
int number = int.Parse(ReadLine());

if (Palindrome(number) == true)
    WriteLine("Число является палиндромом");
else
    WriteLine("Число не является палиндромом");