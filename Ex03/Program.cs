/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunctionAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAckermann(m - 1, 1);
    if ((m > 0) && (n > 0)) return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    return FunctionAckermann(m, n);
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

// Вычисление функции Аккермана и вывод результата на экран.
Console.Write($" -> A({numM},{numN}) = {FunctionAckermann(numM, numN)}");