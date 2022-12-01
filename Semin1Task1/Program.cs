//Задача 1. Ввод- два числа. Вывод- равно ли первое число квадрату второго.

//Считываем данные с консоли(вводим два числа)
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (num1Line != null && num2Line != null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    //Проверяем равно ли первое число квадрату второго 
    if (num1 == num2 * num2)
    {
        //Если равно, то выводим ответ "Yes"
        Console.WriteLine("Yes");
    }
    else
    {
        //Если нет, то выводим ответ "No"
        Console.WriteLine("No");
    }
}
