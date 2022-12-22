// Задача №51
//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

//Метод считывает  данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

//Метод считает сумму элементов главной диагонали
int CalcDiag(int[,] matrix)
{
    int res = 0;
    int min = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);

    for (int i = 0; i < min; i++)
    {
        res += matrix[i, i];
    }

    return res;
}

//Метод печатает цветной двумерный массив
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод вывода данных
void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}


int row = ReadData("Введите количество строк "); //Ввод данных
int column = ReadData("Введите количество столбцов "); //Ввод данных
int[,] arr2D = Fill2DArray(row, column, 10, 99); //Заполнение массива
Print2DArrayColor(arr2D); //Печать массива
int sumOfDiag = CalcDiag(arr2D); //Расчет суммы элементов диагонали
PrintData("Сумма элементов на главной диагонали равна: ", sumOfDiag); //Вывод результата