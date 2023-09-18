Console.WriteLine("Введите первое число: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number = Convert.ToInt32(Console.ReadLine());
if (number * number == square)
{
    Console.WriteLine("True");
} 
else { 
    Console.WriteLine("False");
}