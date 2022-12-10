//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода значения "Полиндром" или "Не Полиндром"
void PrintData(bool res)
{
    if (res == true) 
    {
        Console.WriteLine("Полиндром");
    }
    else 
    {
    Console.WriteLine("Не Полиндром");
    }
}

//Метод проверки на полиндром
bool PolinTest(int num)
{
bool res = false; 
res = ((num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10));
return res;
}


int num = ReadData("Введите число");
bool check = PolinTest(num);
PrintData(check);
