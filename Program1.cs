using System;

class Program1
{
    static void Main1()
    {
        Console.Write("첫 번째 수 : ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("두 번째 수 : ");
        int num2 = int.Parse(Console.ReadLine()!);

        // 최대공약수(GCD) 구하기
        int gcd = GetGCD(num1, num2);

        // 최소공배수(LCM) 구하기
        long lcm = GetLCM(num1, num2, gcd);

        Console.WriteLine();
        Console.WriteLine($"최대공약수 : {gcd}");
        Console.WriteLine($"최소공배수 : {lcm}");
    }

    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    static long GetLCM(int a, int b, int gcd)
    {
        return ((long)a * b) / gcd;
    }
}