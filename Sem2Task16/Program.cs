//Задача №16. Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.


//Ввод нового метода TestSQRT
void TestSQRT(int i, int j)
{
    //Оператор возвращает значение- правда/ложь
    bool result = (i/j==j);
    
    //Если правда- вывод на консоль ...
    if(result==true)Console.WriteLine(" Число "+i+" является квадратом числа "+j);
    
    //Если ложь- вывод на консоль ...
    else Console.WriteLine(" Число "+i+" не является квадратом числа "+j);
}

//Ввод переменной и проверка на ноль
int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");

//Обращение к методу
TestSQRT(number1,number2);
TestSQRT(number2,number1);