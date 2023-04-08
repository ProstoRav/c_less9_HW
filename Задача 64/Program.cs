﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int CreateNumber()
{
    int number;
    Console.Write($"Введите натуральное число: ");
    int.TryParse(Console.ReadLine()!, out number);
    if (number < 1)
    {
        Console.WriteLine($"Вы ввели не натуральное число или 0, пожалуйста перезапустите программу");
        Environment.Exit(0);
    }
    return number;
}

void AllNumbersFromNumberTo1(int number)
{
    Console.Write($"{number}, ");
    if (number == 1)
    {
        return;
    }
    AllNumbersFromNumberTo1(number - 1);

}

int number = CreateNumber();
Console.Write($"N = {number} -> \"");
AllNumbersFromNumberTo1(number);
Console.Write($"\b\b\"");