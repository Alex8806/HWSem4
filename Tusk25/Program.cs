// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
string? s = Console.ReadLine();
bool check = double.TryParse(s, out double a);
while (check == false )
{
    Console.WriteLine("Вы ввели не число , введите число А");
    s = Console.ReadLine(); check = double.TryParse(s, out a);
}
Console.WriteLine("Введите натуральное число B: ");
 s = Console.ReadLine();
check = int.TryParse(s, out int b);
while (check == false | b<0)
{
    Console.WriteLine("Вы ввели не число или не натуральное число, введите число B");
    s = Console.ReadLine(); check = int.TryParse(s, out b);
}
double sum = 1;


for(int i = 0; i<b;sum*=a,i++){}



    
Console.WriteLine (Math.Round(sum,5) + " -это число "+a + " в степени "+ b);



