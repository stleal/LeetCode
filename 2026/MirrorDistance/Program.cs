public class Program {
    public int MirrorDistance(int n) {
        return Math.Abs(n - Reverse(n));
    }
    public static int Reverse(int n)
    {
        string reversed = "";
        while (n > 0)
        {
            int digit = n % 10;
            reversed += digit.ToString();
            n /= 10;
        }
        return Convert.ToInt32(reversed);
    }
}