// Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Метод считывает  данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
   double [,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1)+ new Random().NextDouble();;
        }
    }
    return array2D;
}

//Метод печатает цветной двумерный массив
void Print2DArrayColor(double[,] matrix)
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
            Console.Write(matrix[i, j]+ "__");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк "); //Ввод данных
int column = ReadData("Введите количество столбцов "); //Ввод данных
double [,] arr2D = Fill2DArray(row, column, 10, 99); //Заполнение массива
Print2DArrayColor(arr2D); //Печать массива