public class Program
{
    public static void Main(string[] args)
    {
        int[] seats = new int[] { 3, 1, 5 };
        int[] students = new int[] { 2, 7, 4 };
        var result = MinMovesToSeat(seats, students);
        Console.WriteLine("Minimum number of moves to seat students: " + result);
    }

    public static int MinMovesToSeat(int[] seats, int[] students)
    {
        var index = 0;
        var moves = 0;
        Array.Sort(seats);
        Array.Sort(students);

        foreach (var student in students)
        {
            var difference = students[index] - seats[index];
            for (int i = 0; i < Math.Abs(difference); i++)
            {
                students[index] += (difference > 0) ? 1 : -1;
                moves++;
            }
            index++;
        }

        return moves;
    }
}
