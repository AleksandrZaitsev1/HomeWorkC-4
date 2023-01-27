/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

Console.Write(" Введите Имя   ");
string? username = Console.ReadLine();
Console.Write("Привет!");
Console.WriteLine(username);

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}