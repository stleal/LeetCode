/********************
 * Name: Sam Leal
 * Date: 03/26/2023
 *******************/
namespace Easy.AddBinary;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World");
        // Generate 1,000 random computations of binary numbers (0-255)
        var rng = new System.Random();
        for (int k = 0; k < 1000; k++)
        {
            int x = rng.Next(256); // 0..255
            int y = rng.Next(256);
            string a = Convert.ToString(x, 2).PadLeft(8, '0');
            string b = Convert.ToString(y, 2).PadLeft(8, '0');
            string result = AddBinary(a, b);
            Console.WriteLine($"{a} + {b} = {result}" + "| (" + x + "+" + y + "=" + ConvertBinaryToInt(result) + ")");
        }
    }

    // returns the sum of two binary strings
    public static string AddBinary(string a, string b)
    {
        // Use StringBuilder for efficient string building
        var result = new System.Text.StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        // Process both strings from right to left
        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            // Use direct indexing instead of ElementAt for O(1) access
            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }
            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            // Append the result bit directly as char
            result.Append((char)(sum % 2 + '0'));
            carry = sum / 2;
        }

        // Convert to char array, reverse it, then create string
        var chars = result.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    private static string ConvertBinaryToInt(string result)
    {
        if (string.IsNullOrEmpty(result))
            return "0";

        try
        {
            int value = Convert.ToInt32(result, 2);
            return value.ToString();
        }
        catch (Exception)
        {
            // Fallback: manual parse in case of unexpected characters
            int val = 0;
            foreach (char c in result)
            {
                val = (val << 1) + (c == '1' ? 1 : 0);
            }
            return val.ToString();
        }
    }

}