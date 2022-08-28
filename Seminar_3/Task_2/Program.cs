// Task: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// можно рассматривать пространство любой размерности, изменив N

int N = 3;

int[] A = new int[N];
int[] B = new int[N];

Console.WriteLine("Введите координаты первой точки : ");

for (int i = 0; i < N; i++)
{
    A[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите координаты второй точки : ");
for (int i = 0; i < N; i++)
{
    B[i] = Convert.ToInt32(Console.ReadLine());
}

double distance = 0;
int sumOfSquares = 0;

for (int i = 0; i < N; i++ )
{
    sumOfSquares += (A[i] - B[i]) * (A[i] - B[i]);
}

distance = Math.Sqrt(sumOfSquares);

Console.WriteLine("Расстояние между точками равно " + distance);