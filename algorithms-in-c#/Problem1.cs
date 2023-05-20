/* 

1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

Sample Input:
1, 2
3, 2
2, 2

Expected Output:
3
5
12 

 */

static void Sum(int x, int y)
    {
    int z = 0;
    z = x + y;
    if (x == y)
    {
        z = z * 3;
    }
    Console.WriteLine(z);
    }

Sum(1, 2);
Sum(3, 2);
Sum(2, 2);