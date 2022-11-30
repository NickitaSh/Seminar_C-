
//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(inputLine!=null)
{
    //Парсим введенное число
    int inputNum = int.Parse(inputLine);
    
    //Находим квадрат числа
    //int outNum = inputNum*inputNum;
    //int outNum = (int)Math.Pow(inputNum,2);
    
    //Выводим данные в консоль
    //Console.WriteLine(outNum);
    Console.WriteLine(Math.Pow(int.Parse(inputLine),2));
}
