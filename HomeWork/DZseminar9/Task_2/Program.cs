//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
//
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}


int SumNumbers(int m, int n)
{
   return m == n ? n : m + SumNumbers(m + 1, n);
   /* if (m == n) return n;
        return m + SumNumbers(m + 1, n);
    */
}

int m = Prompt("Введите начение M -> ");
int n = Prompt("Введите начение N -> ");
System.Console.Write($"{SumNumbers(m, n)}  ");

