//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Тесты:
//5 -> 2, 4
//8 -> 2, 4, 6, 8

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



int Number = Promt("Введите правую границу диапазона [1..N], целое число N -> ");
System.Console.Write($"{Number} ->  ");
if (Number < 1)
{
    System.Console.WriteLine("Неправильно введена граница диапазона, должно быть [1..N]");
}
else
{
    if (Number == 1)
    {
        System.Console.WriteLine("Диапазон не содержит четных чисел");
    }
    else
    {
        for (int i = 2; i <= Number; i += 2)
        {
            System.Console.Write($"{i}  ");
        }
    }

}