// Задача 2. Ввод- два числа. Вывод- максимальное из них.

//Считываем данные с консоли(вводим два числа)
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (num1Line != null && num2Line != null)
{
    //Вводим новую переменную. Присваеваем ей значение 0.
    int max = 0;

    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    //Сравниваем введенные числа.
    if (num1 > num2)
    {
        //Если верно, то переменной max присваеваем значение первого числа
        max = num1;
        Console.WriteLine("max="+max);
    }
    else
    {
        //Если неверно, то переменной max присваеваем значение второго числа
        max = num2;
        Console.WriteLine("max="+max);
    }
}