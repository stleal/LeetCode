public class MinMovesToSeatSolution {
    public int MinMovesToSeat(int[] seats, int[] students) {
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