// Задача №42 
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));//Конвертация с помощью расчета
PrintData("Result: " + DecToBinNativ(inputNumber));//Конвертация с помощью сущесвующей функции
PrintData("Result: " + Convert.ToString(inputNumber, 8));//Конвертация в 8-ную систему исчислений
PrintData("Result: " + Convert.ToString(inputNumber, 16));//Конвертация в 16-ную систему исчислений

//Метод считывает  данные от пользователя
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

//Метод конвертации с помощью расчета
string DegToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}


//Метод конвертации с помощью сущесвующей функции
string DecToBinNativ(int num)
{
    return Convert.ToString(num, 2);
}