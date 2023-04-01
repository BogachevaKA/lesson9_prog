/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Function(m, n);

void Function(int m, int n)
{
    Console.WriteLine($"Результат вычисления по функции Аккермана равен: {Result(m, n)}");
}


int Result(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0 && m > 0)
        return Result(m - 1, 1);
    return (Result(m - 1, Result(m, n - 1)));
}