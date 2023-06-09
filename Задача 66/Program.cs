﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int CreateNumber()
{
    int number;
    Console.Write($"Введите натуральное число: ");
    bool success = int.TryParse(Console.ReadLine()!, out number);
    if (!success)
    {
        Console.WriteLine($"Ошибка распознавания числа, попробуйте ещё раз");
        Console.WriteLine();
        number = CreateNumber();
    }
    if (number < 1)
    {
        Console.WriteLine($"Вы ввели не натуральное число, попробуйте ещё раз");
        Console.WriteLine();
        number = CreateNumber();
    }
    return number;
}

int SumNumbersInbetween(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    else if (number1 > number2)
    {
        return number2 + SumNumbersInbetween(number1, number2 + 1);
    }
    return number1 + SumNumbersInbetween(number1 + 1, number2);
}

int numberM = CreateNumber();
int numberN = CreateNumber();
Console.Write($"M = {numberM}; N = {numberN} -> {SumNumbersInbetween(numberM, numberN)}");
