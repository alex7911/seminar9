/*
Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
// Ввод в консоль
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

//Выводим числа от N до 1
string PrintNumbers(int start)
{
    if (start == 1)
        return start.ToString();
    return start + " " + PrintNumbers(--start);
}

//Ввод в консоль
int first = InputNum("Введите число N: ");

//Вывод
Console.WriteLine(PrintNumbers(first));
