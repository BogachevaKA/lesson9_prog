/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите целое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N:");
int n = Convert.ToInt32(Console.ReadLine());

void Summa(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    Summa(m, n, sum);
}
Summa(m, n, 0);