namespace CodeWars._8_kyu
{
    public class SimpleFun1SeatsInTheater
    {
        public static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            int output;
            output = ((nCols - (col - 1)) * (nRows - row));
            return output;
        }
    }
}
