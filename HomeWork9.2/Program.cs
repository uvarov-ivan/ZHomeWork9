// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string msg)
{
    System.Console.Write($"Введите значение {msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int first, int second)
{
    if (first == 0) return second + 1;
    if (second == 0) return AckermanFunction(first - 1, 1);
    return AckermanFunction(first - 1, AckermanFunction(first, second - 1));
}

int m = InputInt("M");
int n = InputInt("N");
System.Console.WriteLine(AckermanFunction(m, n));
