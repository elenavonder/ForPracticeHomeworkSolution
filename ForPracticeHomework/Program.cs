using System;

namespace ForPracticeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
         //practicing foreach with array of strings
            var Class = new string[]
            {
                "Elena", "Christian", "Manami", "Mark", "Yvonne", "Greg"
            };
            foreach (var name in Class)
            {
                Console.WriteLine($"The Class list is {name}");
            }
           
         //Practicing getting total using foreach 
            int[] numbers = {28, 62, 89, 67, 6,
                62, 88, 43, 10, 26};
            var total2 = 0;
            foreach (var Elena in numbers)
            {
                total2 = total2 + Elena;
            }
            Console.WriteLine($"Foreach Answer Is {total2}");
         //practicing getting the sum for odd numbers
            int[] ints = {17, 94, 51, 51, 89, 47, 68,
                40, 65, 32, 41, 41, 63, 39, 61, 44, 83};
            var sumOfOdds = 0;
            var ArrayOfNbrs = ints.Length;
                for(var idx = 0; idx < ArrayOfNbrs; idx++)
            {
                if (ints[idx] % 2 == 1)
                { 
                sumOfOdds = sumOfOdds + ints[idx];//you forgot ints and {}
                }
            }
            Console.WriteLine($"The Sum Of Odd Numbers is {sumOfOdds}");

         //Practicing finding the sum of a group of numbers
            int[] nbrs1 = { 573, 595, 468, 191, 964, 345 };
            var total1 = 0;
            for (var idx=0; idx<=4; idx++)
            {
                total1 = total1 + nbrs1[idx];
            }
            Console.WriteLine($"The Array Answer Is {total1}");

         //Practicing For and If Methods
            var total = 0;
            for (var nbr = 1; nbr <= 50; nbr++)
            {
                if (nbr % 5 == 0 || nbr % 7 == 0)
                    total = total + nbr;
            }
            Console.WriteLine($"The Total Answer That Is Divisible By 5 And 7 Is {total}");
        }
    }
}
