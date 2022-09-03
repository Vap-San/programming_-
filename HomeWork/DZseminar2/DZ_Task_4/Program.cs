//Задача 4: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

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

int Number = Promt("Введите день недели -> ");

if (Number >= 1 && Number <= 7)
{
    if (Number % 6 == 0 || Number % 7 == 0)
    {
        System.Console.WriteLine($"{Number} -> да");
    }
    else
    {
        System.Console.WriteLine($"{Number} -> нет");
    }
}
else
{
    System.Console.WriteLine("Введенный день недели находится вне диапазона [1..7]");
}