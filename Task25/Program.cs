/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

int Exponentiation(int numbA, int numbB)
{
  int result = 1;
  for(int i=1; i <= numbB; i++)
  {
    result = result * numbA;
  }
    return result;
}

  
  Console.Write(" Введите Имя   ");
string? username = Console.ReadLine();
Console.Write("Привет!");
Console.WriteLine(username);
  
Console.Write("Введите число A: ");
  int numbA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numbB = Convert.ToInt32(Console.ReadLine());
  int exponentiation = Exponentiation(numbA, numbB);
  Console.WriteLine("Ответ: " + exponentiation);