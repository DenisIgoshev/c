//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
//на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

Console.Write("ведите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // "12" -> 12
int square = number * number;
System.Console.WriteLine($"Квадрат числа {number} = {square}"); // $ - мы делаем ссылку на переменую.
