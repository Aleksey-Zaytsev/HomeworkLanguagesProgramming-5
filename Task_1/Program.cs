//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Console.Write("[ ");
for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
        Console.Write($"{numbers[i]} ");
    }
Console.Write("]");
Console.WriteLine(" <- Массив чисел ");

int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

Console.WriteLine($"В массиве {numbers.Length} чисел, {count} из них чётные.");

 


