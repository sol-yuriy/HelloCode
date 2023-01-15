Console.Write("Введите вес 1 гири: ");
int a = Convert.ToInt32(Console.ReadLine());
//int b=2;
Console.Write("Введите вес 2 гири: ");
int b = Convert.ToInt32(Console.ReadLine());
//int c=6;
Console.Write("Введите вес 3 гири: ");
int c = Convert.ToInt32(Console.ReadLine());
//int d=8;
Console.Write("Введите вес 4 гири: ");
int d = Convert.ToInt32(Console.ReadLine());
//int e=5;
Console.Write("Введите вес 5 гири: ");
int e = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);