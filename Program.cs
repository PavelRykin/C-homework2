/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Третье число данного числа равно " + findThirdNumber(number));

int findThirdNumber(int a)
{
    while (a < 100 && a > -100)
    {
        Console.Write("Введите число не меньше трёх цифр ");
        a = int.Parse(Console.ReadLine());
    }
    if (a > 99 && a < 1000)
    {
        a = a % 100;
        a = a % 10;
    }
    else if (a > 999 && a < 10000)
    {
        a = a % 1000;
        a = a % 100;
        a = a / 10;
    }
    else if (a > 9999 && a < 100000)
    {
        a = a % 10000;
        a = a % 1000;
        a = a / 100;
    }
    return a;
}