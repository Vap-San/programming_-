//3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

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

int NumberOne = Promt("Введите первое целое число -> ");
int NumberTwo = Promt("Введите второе целое число -> ");


if (NumberOne % NumberTwo == 0)
{
    System.Console.WriteLine($"{NumberOne}, {NumberTwo} -> кратно");
}
else
{
    System.Console.WriteLine($"{NumberOne}, {NumberTwo} -> не кратно, остаток {NumberOne % NumberTwo}");
}
