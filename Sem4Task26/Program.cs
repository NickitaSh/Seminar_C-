//Задача №26
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}
int number = ReadData("Введите число А:");
int length = VariantLog(number);
PrintData("Количество цифр в числе равно^ " + length);
