Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int num = a % 2;
Console.WriteLine(num);
if (num == 0) Console.WriteLine($"Является четным число {a}");
if (num == 1) Console.WriteLine($"Не является четным число {a}");




