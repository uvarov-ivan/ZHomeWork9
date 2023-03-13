// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int InputInt(string msg)
{
    System.Console.Write($"Введите значение {msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersInInterval(int start, int end)
{
    if (start > end) return (0);
    return start + SumNumbersInInterval(start + 1, end);
}

int m = InputInt("M");
int n = InputInt("N");
System.Console.WriteLine(SumNumbersInInterval(m, n));
