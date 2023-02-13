/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Rec(int start, int finish)
{
    if (start == finish) return start;
     return (start + Rec(start + 1, finish));
}

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Получение числа M и N от пользователя.
int numM = GetNum("Введите число M : ");
int numN = GetNum("Введите число N : ");

// Суммирование элементов от M до N и вывод значения суммы на экран.
Console.Write($" -> {Rec(numM, numN)}");