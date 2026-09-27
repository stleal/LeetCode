public class Program {
    public string AddBinary(string a, string b) {
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
}