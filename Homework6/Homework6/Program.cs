using System;
using System.Linq;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            /*1.	დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს 
             * მასივის ზომას , n რაოდენობის ელემენტს შეინახავს მასივში.
             * შემდეგ  ამ მასივიდან  გაფილტრავს ელემენტს ლუწ რიცხვებს 
             * შეინახავს 1 მასივში ხოლო კენტებს მეორეში . */

            Console.Write("Enter size of array : ");
            int size = int.Parse(Console.ReadLine());
            int[] inputArray = new int[size];

            Console.WriteLine($"Enter {size} elements separated by space:");
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {
                inputArray[i] = int.Parse(elements[i]);
            }


            int[] evenArray = new int[size];
            int[] oddArray = new int[size];
            int evenCount = 0;
            int oddCount = 0;


            foreach (var number in inputArray)
            {
                if (number % 2 == 0)
                {
                    evenArray[evenCount] = number;
                    evenCount++;
                }
                else
                {
                    oddArray[oddCount] = number;
                    oddCount++;
                }
            }

            Console.WriteLine("Even Array");
            for (int i = 0; i < evenCount; i++)
            {
                Console.WriteLine($"{evenArray[i]} ");
            }

            Console.WriteLine("Odd Array");
            for (int i = 0; i < oddCount; i++)
            {
                Console.WriteLine($"{oddArray[i]} ");
            }

            #endregion


            #region Task2
            ///*2.	დაწერეთ პროგრამა რომელიც მასივში დათვლის თითოეული
            // * ელემენტის რაოდენობას .და გამოიტანს მათ ჯამს 
            //    */

            Console.WriteLine("Enter array of size: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] inputArray2 = new int[size2];

            Console.WriteLine($"Enter {size2} elements separated by space:");
            string[] elements2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < size2; i++)
            {
                inputArray2[i] = int.Parse(elements2[i]);
            }

            //Console.WriteLine(inputArray2.Sum());
            var groupedElements = inputArray2.GroupBy(x => x)
                                            .Select(group => new
                                            {
                                                Element = group.Key,
                                                Count = group.Count(),
                                                Sum = group.Key * group.Count()
                                            });
            foreach (var group in groupedElements)
            {
                Console.WriteLine($"{group.Element} appears {group.Count} times, sum {group.Sum}");
            }

            #endregion


            #region Task3
            /*3.	დაწერეთ პროგრამა რომელიც გვიჩვენებს ტოპ n მონაწილის შედეგს . 
             * მაგ (1 2 3 4 5 6 7 8 9 10)*/

            //int[] inputArray3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Console.WriteLine("Enter array of size: ");
            int size3 = int.Parse(Console.ReadLine());
            int[] inputArray3 = new int[size3];

            Console.WriteLine($"Enter {size3} elements separated by space:");
            string[] elements3 = Console.ReadLine().Split(' ');

            for (int i = 0; i < size3; i++)
            {
                inputArray3[i] = int.Parse(elements3[i]);
            }


            Console.WriteLine("Enter number of top participants: ");
            int top = int.Parse(Console.ReadLine());


            var topParticipants = inputArray3.OrderByDescending(p => p).Take(top);

            Console.WriteLine($"Top {top} participants: {string.Join(" ", topParticipants)}");

            #endregion

            Console.ReadLine();
        }
    }
}

    