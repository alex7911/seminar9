/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
// Ввод в консоль
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0 && m > 0)
        return Akkerman(m - 1, 1);
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

//Ввод в консоль
int m = InputNum("Введите число М: ");
int n = InputNum("Введите число N: ");

//Вывод
Console.WriteLine(Akkerman(m, n));
