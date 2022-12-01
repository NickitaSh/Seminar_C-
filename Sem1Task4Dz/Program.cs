//Задача 4. Ввод- три числа. Вывод- максимальное из них.

//Считываем данные с консоли(вводим три числа)
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (num1Line != null && num2Line != null && num3Line != null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    //Вводим новую переменную равную значению функции находящей максимальное число.
    int max = Math.Max(num1, Math.Max(num2, num3));

    //Выводим на консоль максимальное число.
    Console.WriteLine("max=" + max);
}