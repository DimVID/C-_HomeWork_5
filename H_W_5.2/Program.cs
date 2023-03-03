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

//------------------------------------------------------------------------------------------------------

// int size = ReadInt("Введите размерность массива: ");
// int min = ReadInt("Введите минимальное число массива: ");
// int max = ReadInt("Введите максимальное число массива: ");
// int [] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         result += numbers[i];
//     }
// }
// Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

// // Методы
// void FillArrayRandomNumbers(int [] array) //Заполнение массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
// }

// void PrintArray(int[] array) //Вывод массива на экран
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)  //Функция ввода
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


//________________________________________----------------------------------------------------__________________________

// using static System.Console;
// Clear();
// Write("Введите размер массива: ");
// int length=int.Parse(ReadLine()!);
// Write("Введите минимальное значение массива: ");
// int min=int.Parse(ReadLine()!);
// Write("Введите максимальное значение массива: ");
// int max=int.Parse(ReadLine()!);
// int[] Array= GetArray(length, min, max);
// WriteLine($"[{string.Join(", ", Array)}]"); 
// FindOdd(Array);
// int[] GetArray(int size, int minValue, int maxValue)
// {Random rnd= new Random(); // переменная генератор случайных чисел
// int[] result= new int[size];
// for(int i= 0; i< result.Length; i++)
// {
//     result[i] = rnd.Next(minValue, maxValue+ 1);
// }
// return result;
// }
// void FindOdd(int[] MyArray)
// {
//     int odd=0;
//     for(int i= 1; i< MyArray.Length; i=i+2)
//     {
//         odd=odd+MyArray[i];
//         }
//         WriteLine($"Сумма чисел на нечётных позициях {odd} ");
//         }
        