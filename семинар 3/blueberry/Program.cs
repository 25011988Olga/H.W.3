Console.Write("Введите кол-во кустов,с которых будут собраны ягоды: ");// дано из условия(собирает с куста напротив и с соседних,их 2)
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ягод,которое можно собрать с куста: ");// дано в условии, максимум 1000. у нас спрашивается сейчас про максимум
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n*a);