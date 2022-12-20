// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод считает количество положительных чисел введенных пользователем
int CountPosNum(int num)
{
    int res = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число{i + 1}: ");
        int digit = int.Parse(Console.ReadLine() ?? "0");
        if (digit > 0) res++;
    }
    return res;
}

int num = ReadData("Введите количество чисел: "); //Ввод количества чисел
int res = CountPosNum(num); //Расчет количества чисел > 0
PrintData("Количество чисел > 0 равно:" + res);// Вывод результата