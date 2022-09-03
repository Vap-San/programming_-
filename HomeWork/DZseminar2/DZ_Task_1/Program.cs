//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное число невозможно перевести в целое число");
}

int Number = Promt("Введите целое число -> ");
if (Number >99 && Number <1000)
{
System.Console.WriteLine($"Вторая цифра числа {Number} равна {Number /10 % 10}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}