//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.




//int Promt(string message) ввод целого числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


ulong DegreeNumbers(int basis, int index)
{
    ulong degree = 1;
    ulong outBasis = Convert.ToUInt64(basis);
    for (int i = 1; i <= index; i++)
    {
        degree *= outBasis;
    }
    return degree;
}



//Основная программа
int basisA = Promt("Введите основание степени -> ");
int indexA = Promt("Введите показатель степени -> ");
System.Console.Write($"{basisA} в степени {indexA} - > {DegreeNumbers(basisA, indexA)}");

