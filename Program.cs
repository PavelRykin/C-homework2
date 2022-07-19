/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());

while (number < 100 && number > -100)
{
    Console.Write("Введите трехзначное число ");
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine("Второе число это " + findSecondNumber(number));

int findSecondNumber(int a)
{
    a = a / 10;
    a = a % 10;
    return a;
}

