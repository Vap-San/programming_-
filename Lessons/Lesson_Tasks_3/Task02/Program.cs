//Задача 2: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

//int Promt(string message) ввод номера четверти
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Проверка вводимых значений
bool ValidateQuarter(int quarter)
{
    if (quarter >= 1 && quarter <= 4) return true;
    System.Console.WriteLine("Указанная четверть не существует, должно быть от 1 до 4");
    return false;
}


//void SpanQuarter(int quarter)- определяет допустимый диапазон координат
void SpanQuarter(int quarter)
{
    if (quarter == 1)
    {
        System.Console.WriteLine("Координата Х изменяется в диапазоне от 0 до бесконечности");
        System.Console.WriteLine("Координата Y изменяется в диапазоне от 0 до бесконечности");
    }
    if (quarter == 2)
    {
        System.Console.WriteLine("Координата Х изменяется в диапазоне от минус бесконечности до 0");
        System.Console.WriteLine("Координата Y изменяется в диапазоне от 0 до бесконечности");
    }
    if (quarter == 3)
    {
        System.Console.WriteLine("Координата Х изменяется в диапазоне от минус бесконечности до 0");
        System.Console.WriteLine("Координата Y изменяется в диапазоне от минус бесконечности до 0");
    }
    if (quarter == 4)
    {
        System.Console.WriteLine("Координата Х изменяется в диапазлне от 0 до бесконечности");
        System.Console.WriteLine("Координата Y изменяется в диапазоне от минус бесконечности до 0");
    }
}

//Основная программа

int quarter = Promt("Введите номер четверти (от 1 до 4) -> ");

if (ValidateQuarter(quarter)) SpanQuarter(quarter);
