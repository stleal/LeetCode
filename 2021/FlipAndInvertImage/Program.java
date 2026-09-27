/*
 * Problem: Flip and Invert Image
 * Description: Reverse each row of a binary matrix and then invert all values from 0 to 1 and 1 to 0.
 */

class Program
{
    public int[][] flipAndInvertImage(int[][] image)
    {
        int col;
        int flippedImage[][];
        col = 0;
        flippedImage = new int[image.length][image[0].length];
        for (int i = 0; i < image.length; i++)
        {
            for (int j = image[0].length - 1; j >=0; j--)
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
