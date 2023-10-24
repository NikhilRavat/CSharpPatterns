namespace CSharpPatterns;

public class Pattern1
{
    public static void InvertedTriangle()
    {
        for (int i = 8; i >= 1; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    public static void Triangle()
    {
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    public static void Diamond()
    {
        int count = 5;
        for (int i = 0; i < count; i++)
        {
            for (int j = 1; j <= (count - i); j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = count; i > 0; i--)
        {
            for (int j = 1; j <= count - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 2 * i - 1; k > 0; k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void RightAngleTriangle()
    {
        int count = 8;
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < (count - i); j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void Parallelogram()
    {
        int count = 8;
        for (int k = 0; k < count; k++)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < count; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void HollowRectangle()
    {
        int count = 8;
        for (int i = 0; i <= count; i++)
        {
            for (int j = 0; j <= count; j++)
            {
                if (j == 0 || i == 0 || j == count || i == count)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void Castle()
    {
        int count = 8;

        for (int i = 1; i <= count; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write("*");
            }
            for (int k = count; k > count - i; k--)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            // for (int j = 1; j < i; j++)
            // {
            //     Console.Write("*");
            // }
            Console.WriteLine();
        }
    }
}