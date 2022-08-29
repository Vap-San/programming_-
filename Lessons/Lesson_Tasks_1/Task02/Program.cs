//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да
//Ввод числа по приглашению
int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    int value = int.Parse(strValue); //Преобразование строки в целое число 
    return value;
}
int FirstValue = Promt("Введите первое число > ");
int SecondValue = Promt("Введите второе число > ");
if (FirstValue == SecondValue*SecondValue )
{
  System.Console.WriteLine("Является"); 
} 
else
{
    System.Console.WriteLine("Не является"); 
}


