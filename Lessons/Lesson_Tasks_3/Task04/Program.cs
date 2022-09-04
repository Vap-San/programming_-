//Задача 4: Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4


//int Promt(string message) ввод целого числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Проверка вводимых значений
bool Validate(int n)
{
    if (n > 0) return true;
    System.Console.WriteLine("Введено недопустимое значение, должно быть > 0");
    return false;
}

void TableSquares(int num)
{
    for (int i = 0; i < num; i++)
    {
        System.Console.Write($"{Math.Pow(i + 1, 2)} ");
    }
}

//Основная программа
int number = Promt("Введите число -> ");
if (Validate(number))
{
    System.Console.Write($"{number} - > ");
    TableSquares(number);
}
