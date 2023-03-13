// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string msg)
{
    System.Console.Write($"Введите значение {msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void FindEvenNumbers(int start, int end)
{
    if (start > end) return;
    if (start % 2 != 0) start++;
    System.Console.Write($"{start}, ");
    FindEvenNumbers(start + 2, end);
}

int m = InputInt("M");
int n = InputInt("N");
FindEvenNumbers(m, n);
