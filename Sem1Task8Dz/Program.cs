// Задача 8. Ввод- число N. Вывод- все четные числа от 0 до N.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    
    //Присваеваем новой переменной значение 2
    int startNumber = 2;
    
    //Вводим пустую строку
    string outLine = string.Empty;
    
    //Запускаем цикл до выполнения условия
    while (startNumber < inputNumber - 2)
    {
        outLine = outLine + startNumber + ", ";
        startNumber = startNumber + 2;
    }
    outLine = outLine + startNumber;
    
    // Выводим данные в консоль
    Console.WriteLine(outLine);
}
