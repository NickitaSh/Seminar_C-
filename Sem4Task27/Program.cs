//Задача 27: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.;

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(int sum)
{
    Console.WriteLine(sum);
}

//Метод считает сумму цифр в числе
int SumDigit (int num)
{
    int sum =0;
    while(num > 0)
    {
        sum= num%10+sum;
        num= num/10;
    }
    return sum;
}

//Вывод числа с помощью метода ReadData
int num = ReadData("Введите число: ");

//Расчет суммы с помощью метода SumDigit
int sum = SumDigit(num);

//Вывод расчета 
PrintData(sum);