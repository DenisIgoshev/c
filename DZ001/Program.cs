using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;

Console.WriteLine("Введите номер задачи: ");
int nomer = Convert.ToInt32(Console.ReadLine());
switch (nomer)
{

   case 1:
   //     Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
        {
            Console.WriteLine("Для того, чтобы узнать большее введите первое число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
            System.Console.WriteLine($"MAX {A}");
            }
            else if (A < B)
            {
                System.Console.WriteLine($"MAX {B}");
            }
            else
            {
                System.Console.WriteLine("Цифры равны");
            }
     break;
        }

  case 2:
//   Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
           {
            Console.WriteLine("Для того, чтобы узнать большее введите первое число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int C = Convert.ToInt32(Console.ReadLine());
           
           int max = A;

          if(A > max)  max = A;
          if(B > max)  max = B;
          if(C > max)  max = C;
          System.Console.WriteLine($"MAX = {max}");
       
   break;

           }
   case 3:
//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

          System.Console.WriteLine("Для того, чтобы узнать кратное введите число: ");
          int number = Convert.ToInt32(Console.ReadLine());
          if (number % 2 == 0)
          {
          System.Console.WriteLine("Кратно");
          }
          else
          {
            System.Console.WriteLine("Некратно");
          }

  break;
   case 4:
//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
       
          System.Console.WriteLine("Введите число N: ");
          int N = Convert.ToInt32(Console.ReadLine());
          for(int i = 1; i <= N; i++)
          {
            if(i % 2 == 0)
            {
            System.Console.Write(i+ ",");
            }
          }
          
   break;



// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.
case 5:

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());


   if(num <= 10000)
  {
        int division1 = num / 10000;
        int remainder1 = num % 10;
 
             if(division1 == remainder1)
             {
                 num = num / 10;
               int division2 = (num / 100) % 10;
               int remainder2 = num % 10;

                if(division2 == remainder2)
               {
               Console.WriteLine("Палидром");          
               }
             } 
             else 
             Console.WriteLine("Не палидром");
             
            
   }
     else
     {
     Console.WriteLine("Некорректное число!");
     }



break;


case 6:

// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");



break;

case 7:
// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


// N = 3 
// /*
// 1
// 8
// 27
// */

// N = 5
// /*
// 1
// 8
// 27
// 64
// 125
// */


Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.WriteLine(coll[index]+  " " );
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);







break;

}