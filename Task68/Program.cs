// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("введите аргумент M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите аргумент N: ");
int n = int.Parse(Console.ReadLine());

int Akkerm(int m, int n)
{

    if (m == 0 && n >= 0)
    {
        return (n + 1);
    }
    else if (m > 0 && n == 0)
    {
        return Akkerm(m - 1, 1);

    }

    else if (m > 0 && n > 0)
    {
        return Akkerm(m - 1, Akkerm(m, n - 1));

    }
    else if (m <= 0 && n <= 0) Console.WriteLine("Вы ввели неверное значение, попробуйте снова! ");  // не удалось избавиться от вывода результата 0

    return 0;
}

int rez = Akkerm(m, n);
Console.WriteLine($"Результат вычисления функции Аккермана при заданных значениях равен {rez}");
