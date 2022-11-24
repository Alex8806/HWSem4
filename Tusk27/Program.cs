// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число: ");
string? s = Console.ReadLine();
bool check = int.TryParse(s, out int n);
while (check == false )
{
    Console.WriteLine("Вы ввели не целое число , введите целое число:");
    s = Console.ReadLine(); check = int.TryParse(s, out n);
}
int minus=1;
int sum=0;
for(int i=0; i<s.Length;i++)
{
if(s[i]=='-')
{ minus = -1;
continue;
}
string vrem = Convert.ToString(s[i]);
sum+=((Convert.ToInt16(vrem))*minus);
minus =1;
}
Console.WriteLine("Сумма цифр равна: "+ sum);