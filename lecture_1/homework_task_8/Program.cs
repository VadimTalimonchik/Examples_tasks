/*
Задача 8

Напишите программу, которая на вход
принимает число (N), а на выходе показывает
все чётные числа от 1 до N
*/

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= numberA)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " - четное число в составе числа " + numberA);
    }
    i++;
}
