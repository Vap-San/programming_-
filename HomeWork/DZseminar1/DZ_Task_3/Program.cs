//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
//4 -> да
//-3 -> нет
//7 -> нет

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
bool EvenNumber (int inNumber)
{
    if (inNumber % 2 ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


int Number = Promt("Введите целое число -> ");

if (EvenNumber(Number))
{
    System.Console.WriteLine($"Число {Number} четное");
}
else
{
    System.Console.WriteLine($"Число {Number} нечетное");
}

