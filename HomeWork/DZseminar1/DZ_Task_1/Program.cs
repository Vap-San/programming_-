//Задача 1: Напишите программу, которая на вход принимает два ЦЕЛЫХ числа и выдаёт, какое число большее, а какое меньшее.
//Тесты:
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

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

int max;
int firstNumber = Promt("Введите первое целое число -> ");
int secondNumber = Promt("Введите второе целое число -> ");

if (firstNumber > secondNumber)
{
System.Console.WriteLine($"max= {firstNumber}");
}
else
{
    if (firstNumber < secondNumber)
    {
System.Console.WriteLine($"max= {secondNumber}");

    }
    else
    {
System.Console.WriteLine("числа равны между собой");
    }
}

