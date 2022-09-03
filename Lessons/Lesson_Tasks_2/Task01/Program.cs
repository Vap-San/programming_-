//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
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
System.Console.WriteLine($"Последняя цифра числа {Number} - {Number % 10}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}