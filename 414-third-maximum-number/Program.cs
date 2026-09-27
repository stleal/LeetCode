public class Program {
    public int ThirdMax(int[] nums) {
        long? first = null;
        long? second = null;
        long? third = null;

        foreach (int num in nums)
        {
            if (num == first || num == second || num == third)
            {
                continue;
            }

            if (first is null || num > first)
            {
                third = second;
                second = first;
                first = num;
            }
            else if (second is null || num > second)
            {
                third = second;
                second = num;
            }
            else if (third is null || num > third)
            {
                third = num;
            }
        }
        return third is null ? (int)first! : (int)third.Value;
    }
}