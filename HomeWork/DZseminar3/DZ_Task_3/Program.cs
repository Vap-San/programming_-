//Задача 3: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125



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

void TableDegree3(int num)
{
    for (int i = 0; i < num; i++)
    {
        System.Console.Write($"{Math.Pow(i + 1, 3)} ");
    }
}

//Основная программа
int number = Promt("Введите число -> ");
if (Validate(number))
{
    System.Console.Write($"{number} - > ");
    TableDegree3(number);
}
