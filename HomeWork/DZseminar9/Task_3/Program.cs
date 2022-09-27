//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

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

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
            return AckermanFunction(m - 1, 1);
        else
            return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}



int m = Prompt("Введите начение M -> ");
int n = Prompt("Введите начение N -> ");
System.Console.Write($"{AckermanFunction(m, n)}  ");