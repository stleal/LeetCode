/*
 * Problem: Product of Array Except Self
 * Description: Return a new array where each element is the product of all numbers in the original array except the current element.
 */

class Program
{
    public ArrayList<Integer> data;
    public ProductOfNumbers()
    {
        data = new ArrayList<Integer>();
    }
    public void add(int num)
    {
        data.add(num);
    }
    public int getProduct(int k)
    {
        int product;
        product = -1;
        product = 1;
        for (int i = data.size() - 1; i > data.size() - 1 - k; i--)
        {
            product *= data.get(i);
        }
        return product;
    }
}
/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.add(num);
 * int param_2 = obj.getProduct(k);
 */
