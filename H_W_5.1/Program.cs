// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
System.Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
System.Console.WriteLine("В данном массиве: ");
System.Console.WriteLine($"[{string.Join(", ", numbers)}]");

void RandonNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

int count = 0;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] % 2 == 0)
        count++;
}
System.Console.WriteLine($"четных чисел = {count} ");
