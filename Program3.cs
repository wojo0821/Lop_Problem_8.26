using System;

class Program3
{
    static void Main()
    {
        Console.Write("계단의 높이 : ");
        int n = int.Parse(Console.ReadLine()!);

        if (n <= 0)
        {
            Console.WriteLine("계단의 높이는 1 이상이어야 합니다.");
            return;
        }

        // n이 1이거나 2일 때의 기본 경우
        if (n == 1)
        {
            Console.WriteLine("올라가는 방법의 수 : 1");
            return;
        }
        if (n == 2)
        {
            Console.WriteLine("올라가는 방법의 수 : 2");
            return;
        }

        int[] cases = new int[n + 1];
        cases[1] = 1;
        cases[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            cases[i] = cases[i - 1] + cases[i - 2];
        }

        Console.WriteLine($"올라가는 방법의 수 : {cases[n]}");
    }
}
