// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длинну массива: ");
string? s = Console.ReadLine();
bool check = int.TryParse(s, out int n);
while (check == false | n<0)
{
    Console.WriteLine("Вы ввели не число или отрицательное значение, введите длину массива:");
    s = Console.ReadLine(); check = int.TryParse(s, out n);
}
double[] arr = new double[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите число под индексом {i}");
    s = Console.ReadLine();
    check = double.TryParse(s, out double f);
    while (check == false)
    {
        Console.WriteLine("Вы ввели не число, введите число");
        s = Console.ReadLine(); check = double.TryParse(s, out f);
    }
arr[i]=f;
}

Console.WriteLine("Ваш массив:\t["+String.Join(" ",arr)+ "]");
