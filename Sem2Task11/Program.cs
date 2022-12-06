//Задача 11. Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.

//Вариант 1

// System.Random numberSintezator = new System.Random();  //Создаем экземпляр класса рандомайзер

// int num = numberSintezator.Next(100,1000);             // получаем случайное число
// Console.WriteLine (num);

// //int firstNum = num/100;                            // получаем старший разряд числа
// //int secondNum = num%10;                           // получаем младший разряд числа

// //int result = (num/100)*10 + num%10;               //Составляем из двух цифр число
// Console.WriteLine ((num/100)*10 + num%10);          // Выводим данные в консоль

//Вариант 2

System.Random random = new System.Random();          //Создаем экземпляр класса рандомайзер

int randomNumber = random.Next(100, 1000);           // Получаем случайное число

Console.WriteLine("число: " + randomNumber);         // Выводим данные в консоль

string value = randomNumber.ToString();              //Превращаем переменную в строку  

char[] numberArray = value.ToCharArray();            //Превращаем строку в массив символов 

Console.WriteLine(numberArray[0] + "" + numberArray[2]); // Выводим данные в консоль