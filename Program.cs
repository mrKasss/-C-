Console.Write("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;

//Вывод в лоб
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен ");
Console.WriteLine(result);

//Вывод с $
Console.WriteLine($"Квадрат числа {number} равен {result}");

//Вывод с обращением к переменным
Console.WriteLine("Квадрат числа {0} равен {1}", number, result);

//Использование библиотеки Math
int result1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine("Квадрат числа {0} равен {1}", number, result1);