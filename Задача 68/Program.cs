/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int CreateNumber()
{
    int number;
    Console.Write($"Введите натуральное число: ");
    int.TryParse(Console.ReadLine()!, out number);
    if (number < 0)
    {
        Console.WriteLine($"Вы ввели не натуральное число, пожалуйста перезапустите программу");
        Environment.Exit(0);
    }
    return number;
}

int FindAckermann(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if ((number1 > 0) && (number2 == 0))
    {
        return FindAckermann(number1 - 1, 1);
    }
    return FindAckermann(number1 - 1, FindAckermann(number1, number2 - 1));
}

int numberM = CreateNumber();
int numberN = CreateNumber();
Console.Write($"m = {numberM}, n = {numberN} -> A(m,n) = {FindAckermann(numberM, numberN)}");