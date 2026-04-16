public class ReverseDegreeOfStringSolution
{
    public int ReverseDegree(string s) {
        var sum = 0;
        int[] value = new int[26];
        var index = 0;
        string[] alphabet = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H",
            "I", "J", "K", "L", "M", "N", "O", "P",
            "Q", "R", "S", "T", "U", "V", "W", "X",
            "Y", "Z" };
        for (int i = alphabet.Length-1; i >= 0; i--)
        {
            value[index] = i+1;
        }
        for (int i = 0; i < s.Length; i++)
        {
            index = Array.IndexOf(alphabet, s[i].ToString().ToUpper());
            var x = value[index];
            var product = x*(i+1);
            sum += product;
        }
        return sum;
    }
}