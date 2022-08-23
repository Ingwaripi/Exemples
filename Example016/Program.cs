int Fibonaci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonaci(n - 1) + Fibonaci(n - 2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonaci(i));
}