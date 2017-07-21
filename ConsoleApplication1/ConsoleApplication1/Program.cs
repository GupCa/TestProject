using System;

namespace ConsoleApplication1
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var resultsCount = 0;
            var resultSum = 200;
            var iterations = 0;


            for (var i200 = 0; i200 <= resultSum / 200; i200++)
            {
                for (var i100 = 0; i100 <= (resultSum - CalculateSum(i200)) / 100; i100++)
                {
                    for (var i50 = 0; i50 <= (resultSum - CalculateSum(i200, i100)) / 50; i50++)
                    {
                        for (var i20 = 0; i20 <= (resultSum - CalculateSum(i200, i100, i50)) / 20; i20++)
                        {
                            for (var i10 = 0; i10 <= (resultSum - CalculateSum(i200, i100, i50, i20)) / 10; i10++)
                            {
                                for (var i5 = 0; i5 <= (resultSum - CalculateSum(i200, i100, i50, i20, i10)) / 5; i5++)
                                {
                                    for (var i2 = 0; i2 <= (resultSum - CalculateSum(i200, i100, i50, i20, i10, i5)) / 2; i2++)
                                    {
                                        for (var i1 = 0; i1 <= (resultSum - CalculateSum(i200, i100, i50, i20, i10, i5, i2)) / 1; i1++)
                                        {
                                            iterations++;

                                            if (CalculateSum(i200, i100, i50, i20, i10, i5, i2, i1) == resultSum)
                                            {
                                                resultsCount++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Program finished.");
            Console.WriteLine($"Iterations: {iterations}");
            Console.WriteLine($"Result: {resultsCount}");
            Console.ReadKey();
        }

        private static int CalculateSum(int i200 = 0, int i100 = 0, int i50 = 0, int i20 = 0, int i10 = 0, int i5 = 0, int i2 = 0, int i1 = 0)
        {
            return i200 * 200 +
                   i100 * 100 +
                   i50 * 50 +
                   i20 * 20 +
                   i10 * 10 +
                   i5 * 5 +
                   i2 * 2 +
                   i1;
        }
    }
    
}
