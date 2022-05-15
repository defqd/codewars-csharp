/*
https://www.codewars.com/kata/58261acb22be6e2ed800003a

8 kyu

Bob needs a fast way to calculate the volume of a cuboid with three values: the length, width and height of the cuboid. Write a function to
help Bob with this calculation.
*/
namespace CodeWars._8_kyu
{
    public class VolumeOfACuboid
    {
        public static double GetVolumeOfCubiod(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
