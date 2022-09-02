//Задача 2: Напишите программу, которая принимает на вход три ЦЕЛЫХ числа и выдаёт максимальное из этих чисел.
// Тесты:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

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
int thirdNumber = Promt("Введите третье целое число -> ");

max = firstNumber;
if (secondNumber> max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;

System.Console.WriteLine($"Максимальное из трех чисел {firstNumber}, {secondNumber}, {thirdNumber} равно {max}");


