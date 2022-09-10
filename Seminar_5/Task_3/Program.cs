// Task:  Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] fillArray (int[] array, int start, int stop) 
{
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, stop + 1);
    }
    return array;
}

int[] findMinMax (int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 1; i < array.Length; i++ )
    {
        if (array[i] > max)
        {
            max = array[i];
        } 
        else if (array[i] < min) 
        {
            min = array[i];
        }
    }
    return new int[2] {min, max};
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


int start = 1;
int stop = 99;

array = fillArray(array, start, stop);
printArray(array);
int[] minMaxArr = new int[2];

minMaxArr = findMinMax(array);

int min = minMaxArr[0];
int max = minMaxArr[1];
int diff = max - min;

Console.WriteLine($"Разница между максимальным и минимальным значениями: {diff}");
