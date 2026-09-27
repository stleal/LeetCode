public class Program {
    public int NumberOfSteps(int num) {
        int count = 0;
        int n = num;
        while (n > 0)
        {
            n = (n%2==0) ? n/2 : n-1;
            count++;
        }
        return count;
    }
}