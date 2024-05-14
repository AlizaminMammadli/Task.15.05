namespace The_largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 19, 2, 25, 455 };

            int theLargest = number[0];
            for (int i = 1; i < number.Length; i++)
            {
                if (theLargest < number[i])
                {
                    theLargest = number[i];
                }
            }
            Console.WriteLine("The Largest Number is" + " " + theLargest);
        }
    }
}
