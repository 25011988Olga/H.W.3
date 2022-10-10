Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
a = 0;
t = 0;
for(int i = 0; i<n/2; i++)
t = args[i];
a[i] = a[n-1-i];
a[n-1-i] = t;
if(n==t)
Console.WriteLine("Является");
if(a>t||a<t)
Console.WriteLine("Не является");
