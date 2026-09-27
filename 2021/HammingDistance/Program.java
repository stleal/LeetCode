class Program
{
    public int hammingDistance(int x, int y)
    {
        int hammingDistance;
        int size;
        int xBinaryReversed[], yBinaryReversed[];
        int xBinary[], yBinary[];
        int index, top;
        hammingDistance = 0;
        size = 1;
        // determines how many bits we will need
        if (x > y)
        {
            size = (int) (Math.log10(x) / Math.log10(2)) + 1;
        }
        else if (x < y)
        {
            size = (int) (Math.log10(y) / Math.log10(2)) + 1;
        }
        else if (x == 0 && y == 0)
        {
            size = 1;
        }
        else if (x == y)
        {
            size = (int) (Math.log10(x) / Math.log10(2)) + 1;
        }
        System.out.println("Size: " + size);
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
        System.out.println("xBinary: " + Arrays.toString(xBinary));
        System.out.println("yBinary: " + Arrays.toString(yBinary));
        return hammingDistance;
    }
}
