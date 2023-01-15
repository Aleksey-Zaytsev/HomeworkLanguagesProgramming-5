// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Console.Write("[ ");
for(int i = 0; i < numbers.Length; i++)
    {
         numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        Console.Write($"{numbers[i]}  ");
    }
Console.Write("]");
Console.WriteLine(" <- Массив чисел ");

double max = Int32.MaxValue;
double min = Int32.MinValue;
for (int j = 0; j < numbers.Length; j++)
{
    
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}

Console.WriteLine($"Максимальным числом является: {max} Минимальным числом является: {min}");

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");