


//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


// Console.WriteLine("Input arrat size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Your array: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"ALl {numbers.Length} digit, {count} is even");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
 

 
//  Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArrayRandomNumbers(array);
// Console.WriteLine("Your array: ");
// PrintArray(array);
// int sum = 0;

// for (int z = 0; z < array.Length; z+=2)
//     sum = sum + array[z];

//     Console.WriteLine($"all {array.Length} digit, summa elements even point = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Your array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"All {numbers.Length} digit. maximal = {max}, minimal = {min}");
Console.WriteLine($"maximal-minimaL = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write(" ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("");
    Console.WriteLine();
}