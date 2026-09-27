public class Program {
    public int CountDigits(int num) {
        int count = 0;
        int n = num;
        while (n > 0)
        {
            int digit = n%10;
            count += (num%digit==0) ? 1 : 0;
            n/=10;
        }
        return count;
    }
}