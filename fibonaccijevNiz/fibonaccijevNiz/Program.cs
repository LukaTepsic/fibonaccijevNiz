using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj n za Fibonaccijev niz: ");
        int n = int.Parse(Console.ReadLine());

        int fib = FibonaccijevNiz(n);

        Console.WriteLine($"N-ti član Fibonaccijevog niza (n={n}) je: {fib}");
    }

    static int FibonaccijevNiz(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;

        int a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}
