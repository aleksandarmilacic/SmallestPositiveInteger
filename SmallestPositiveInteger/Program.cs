namespace SmallestPositiveInteger
{
    internal class Program
    {

        public static int SmallestPositiveInteger(int[] A)
        {
            var positiveNumbers = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();
            var minNumber = positiveNumbers.Min(x => x);
            if (minNumber > 1)
            {
                return 1;
            }
            else 
                while (true) 
                { 
                    minNumber = minNumber + 1; 
                    if(!positiveNumbers.Any(a => a == minNumber))
                    {
                        return minNumber; 
                    }
                };
             
        }

        static void Main(string[] args)
        {
            int[] A = { 1, 3, 6, 4, 1, 2 };
            var result = SmallestPositiveInteger(A);
            Console.WriteLine(result);
        }
    }
}