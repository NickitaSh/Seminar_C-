// Задача 7. Ввод- трехзначное число. Вывод- последняя цифра числа.

//Считываем данные с консоли
string? inputLineNum = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLineNum != null)
{
    //Парсим введенное число
    int inputNum = int.Parse(inputLineNum);

    //Вводим новую переменную равную остатку при делении на десять
    int lastDigit = inputNum % 10;

    //Выводим данные в консоль
    Console.WriteLine(lastDigit);
}