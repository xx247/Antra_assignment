using System;


namespace Day06_assignment;

public static class Fibonacci
{ 
    public static int[] Fib(int num)
    {
        int[] result = new int[num];
        result[0] = 1;
        if (num == 1)
        {
            return result;
        }
        else if (num == 2)
        {
            result[1] = 1;
            return result;
        }
        else
        {
            result[1] = 1;
            int i = 2;
            while (i < num)
            {
                result[i] = result[i - 1] + result[i - 2];
                i++;
            }
            return result;
        }
    }

}
