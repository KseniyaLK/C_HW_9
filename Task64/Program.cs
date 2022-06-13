// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1" N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("введите число N: ");
int num = int.Parse(Console.ReadLine());

void PrintNumber(int n)
{
    if (n < 0) 
    {
        Console.Write("Вы ввели неверное число, попробуйте снова!");
        return;
    }    
    else if (n == 0) return;
    else if (n > 0)
    {
        Console.Write(n + " ");
    }
    PrintNumber(n-1);
    return;

}
PrintNumber(num);
