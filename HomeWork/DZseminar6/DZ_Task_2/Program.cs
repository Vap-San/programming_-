//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


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

//основная программа
int k1 = Prompt("Введите коэффициент k1 -> ");
int b1 = Prompt("Введите коэффициент b1 -> ");
int k2 = Prompt("Введите коэффициент k2 -> ");
int b2 = Prompt("Введите коэффициент b2 -> ");
if (k1 != k2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    double y = (double)(k1 * b2 - k2 * b1) / (k1 - k2);
    System.Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
}
else
{
    System.Console.WriteLine($"Прямые параллельны, точки пересечения нет");
}
