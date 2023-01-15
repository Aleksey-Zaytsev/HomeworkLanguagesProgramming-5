// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Console.Write("[ ");
for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
        Console.Write($"{numbers[i]} ");
    }
Console.Write("]");
Console.WriteLine(" <- Массив чисел ");

int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {sum} ");
