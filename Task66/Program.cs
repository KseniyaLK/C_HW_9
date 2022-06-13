// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии. 
// M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

Console.WriteLine("введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N: ");
int n = int.Parse(Console.ReadLine());
int temp = m;

if (m > n)
{
    temp = m;
    m = n;
    n = temp;
}

void SumNumbers(int m, int n, int sum)
{
    sum = sum + m;
    if (m >= n)
    {

        Console.WriteLine($"Сумма чисел равна {sum}");
        return;

    }
    SumNumbers(m + 1, n, sum);
}

SumNumbers(m, n, 0);

