// Task: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] fillArray (int[] array, int start, int stop) 
{
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, stop + 1);
    }
    return array;
}

int countEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
        {
            count++;
        }
    }
    return count;
}

void printArray (int[] array)
{
    int N = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < N - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[N-1]} ]");
}


Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];


int start = 100;
int stop = 999;

array = fillArray(array, start, stop);
printArray(array);
int evenNumbersCount = countEvenNumbers(array);

Console.WriteLine($"Количество четных чисел в массиве: {evenNumbersCount}");