/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели от 1 до 7 ");
int number = int.Parse(Console.ReadLine());

while (number > 7 || number < 1)
{
    Console.WriteLine("Такого номера дня недели нет!");
    Console.WriteLine("Введите номер дня недели от 1 до 7 ");
    number = int.Parse(Console.ReadLine());
}

if (number == 1)
{
    Console.Write("Это Понедельник и он будний день");
}
else if (number == 2)
{
    Console.Write("Это Вторник и он будний день");
}
else if (number == 3)
{
    Console.Write("Это Среда и он будний день");
}
else if (number == 4)
{
    Console.Write("Это Четверг и он будний день");
}
else if (number == 5)
{
    Console.Write("Это Пятница и он будний день");
}
else if (number == 6)
{
    Console.Write("Это Суббота и ура это выходной день!");
}
else if (number == 7)
{
    Console.Write("Это Воскресенье и ура это выходной день!");
}




