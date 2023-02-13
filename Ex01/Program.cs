/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string Rec(int start, int finish = 1)
{
    if (start == finish)  return start.ToString();
    return (start + ", " + Rec(start - 1, finish));
}

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Получение числа N от пользователя. 
int numN = GetNum("Введите число N: ");

// Вывод чисел от N -> 1.
Console.Write($" -> {Rec(numN)}");