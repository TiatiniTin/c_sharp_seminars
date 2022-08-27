// Task: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите порядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 8 && day > 0)
{
    switch (day)
    {
        case 6: 
            Console.WriteLine("Выходной день");
            break;

        case 7: 
            Console.WriteLine("Выходной день");
            break;
        
        default:
            Console.WriteLine("Рабочий день");
            break;
    }
}
else {
    Console.WriteLine("Порядковый номер введен некорректно!");
}