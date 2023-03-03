// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
System.Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("В данном массиве: ");
System.Console.WriteLine($"[{string.Join(", ", numbers)}]"); 

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}

int sum = 0;
for (int j = 0; j < numbers.Length; j+=2)
    {
    sum = sum + numbers[j];
    }

System.Console.WriteLine($"сумма элементов, cтоящих на нечётных позициях = {sum}");
