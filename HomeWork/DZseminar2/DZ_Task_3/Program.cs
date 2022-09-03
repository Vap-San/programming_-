//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

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
int saveNumber= Number;
if (Number >= 100)
{
    while (Number > 999)
    {
        Number /= 10;
    }
    System.Console.WriteLine($"{saveNumber} -> {Number % 10}");
}
else
{
    System.Console.WriteLine($"{Number} -> третьей цифры нет");
}