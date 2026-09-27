public class Program {
    public int PivotInteger(int n) {
        long totalSum = n * (n + 1) / 2;
        long pivot = (long)Math.Sqrt(totalSum);
        return pivot * pivot == totalSum ? (int)pivot : -1;
    }
}