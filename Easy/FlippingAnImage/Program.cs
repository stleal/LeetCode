public class Program
{

    public static void Main(string[] args)
    {
        int[][] image =  new int[3][];
        image[0] = new int[] { 1, 1, 0 };
        image[1] = new int[] { 1, 0, 1 };
        image[2] = new int[] { 0, 0, 0 };
        int[][] result = FlipAndInvertImage(image);
    }

    public static int[][] FlipAndInvertImage(int[][] image)
    {

        int[][] flippedImage;
        int col;

        flippedImage = new int[image.GetLength(0)][];
        col = 0;
        for (int i = 0; i < image.GetLength(0); i++)
        {

            for (int j = image[0].GetLength(0) - 1; j >=0; j--)
            {

                flippedImage[i][col] = image[i][j];

                if (flippedImage[i][col] == 0)
                {

                    flippedImage[i][col] = 1;

                }
                else if (flippedImage[i][col] == 1)
                {

                    flippedImage[i][col] = 0;

                }

                col++;

            }

            col = 0;

        }

        return flippedImage;

    }

}