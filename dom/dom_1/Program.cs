Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int a1 = int.Parse(Console.ReadLine());
int max = a;
if (a1 > max) max = a1;

else
{
max = a;
}
Console.WriteLine($"Наибольшее число {max}");