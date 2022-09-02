// Напишите программу вычисления функции факториал числа а: x = f(a)

int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    int value = int.Parse(strValue); //Преобразование строки в целое число 
    return value;
}


double Factorial(int inNumber)
{
    double rezult = 1;
    for (int i = 2; i <= inNumber; i += 1)
    {
        rezult = rezult * i;
        System.Console.WriteLine($"{i} -> {rezult}");
    }
    return rezult;
}



int Number = Promt("Введите целое число N -> ");

if (Number < 0)
{
    System.Console.WriteLine($"Факториал {Number} не может быть вычислен");
}
else
{
    System.Console.WriteLine($"{Number}! = {Factorial(Number)}");
}