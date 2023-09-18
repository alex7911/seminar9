/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
// Ввод в консоль
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    if (m == n)
        return 0;
    int sum = n + SumMN(m, --n);
    return sum;
}

//Ввод в консоль
int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");

//Вывод
Console.WriteLine(SumMN(m - 1, n));
