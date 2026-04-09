public class Solution
{

    public static void Main(string[] args)
    {
      Solution solution = new Solution();
      int x = 1;
      int y = 4;
      Console.WriteLine("Hamming Distance: " + HammingDistance(x, y));
    }

    public static int HammingDistance(int x, int y)
    {

        int hammingDistance;
        int size;
        int[] xBinaryReversed;
        int[] yBinaryReversed;
        int[] xBinary;
        int[] yBinary;
        int index, top;

        hammingDistance = 0;
        size = 1;

        // determines how many bits we will need
        if (x > y)
        {

            size = (int) (Math.Log10(x) / Math.Log10(2)) + 1;

        }
        else if (x < y)
        {

            size = (int) (Math.Log10(y) / Math.Log10(2)) + 1;

        }
        else if (x == 0 && y == 0)
        {

            size = 1;

        }
        else if (x == y)
        {

            size = (int) (Math.Log10(x) / Math.Log10(2)) + 1;
        }

        Console.WriteLine("Size: " + size);

        xBinaryReversed = new int[size];
        yBinaryReversed = new int[size];
        xBinary = new int[size];
        yBinary = new int[size];

        index = 0;

        // converts x into Binary (it comes out in reverse)
        while (x > 0)
        {

            xBinaryReversed[index++] = x % 2;
            x /= 2;

        }

        index = 0;

        // converts y into Binary (it comes out in reverse)
        while (y > 0)
        {

            yBinaryReversed[index++] = y % 2;
            y /= 2;

        }

        top = 0;

        // reverses the reversed Binary array
        for (int i = size - 1; i >= 0; i--)
        {

            xBinary[top] = xBinaryReversed[i];
            yBinary[top] = yBinaryReversed[i];
            top++;

        }

        // counts how many bits are different
        for (int i = 0; i < size; i++)
        {

            if (xBinary[i] != yBinary[i])
            {

                hammingDistance++;

            }

        }

        Console.WriteLine("xBinary: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(xBinary[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("yBinary: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(yBinary[i] + " ");
        }
        Console.WriteLine();

        return hammingDistance;

    }

}