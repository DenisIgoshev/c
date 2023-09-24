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

}
