using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list1 = new List<int>()                                  //1 task
            { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18, };
            list1 = list1.Where(x => x % 2 == 0).ToList();

            Console.Write("Task 1 The Number output ");
            foreach (var x in list1)
            { Console.Write(x + " "); }

            Console.WriteLine();
            Console.WriteLine(" ==============================================================");

            var list2 = new List<int>()                                  //2 task
            { -1,2,4,-6,-8,9,11,-12,-16 };
            list2 = list2.Where(x => x > 0).ToList();

            Console.Write("Task 2 The Number output ");
            foreach (var x in list2)
            { Console.Write(x + " "); }

            Console.WriteLine();
            Console.WriteLine(" ==============================================================");



            //3 task



            var list3 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,11,12,3,
            };

            var listchanged3 = list3.Select(Number => new { Number, SqrNo = Number * Number }).ToList();



            Console.WriteLine("Task 3 The Number output ");

            foreach (var x in listchanged3)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine(" ==============================================================");


            //task 4

            var list4 = new List<int>()
            {
                5,6,6,7,2,2,1,4,6,7,8,9,9,10
            };

            var listChanged4 = list4.Select(Number => new { number = Number, frequencyOfNumber = list4.Count(num => num == Number) }).Distinct().ToList();



            Console.WriteLine("Task 4 The Number output ");

            foreach (var x in listChanged4)
            {
                Console.WriteLine("The number is " + x.number + " The frequency is " + x.frequencyOfNumber);
            }


            Console.WriteLine();
            Console.WriteLine(" ==============================================================");




            //task 5

            string list5 = "apple";

            var listChanged5 = list5.Select(Letter => new { letter = Letter, frequencyOfletter = list5.Count(let => let == Letter) }).Distinct().ToList();



            Console.WriteLine("Task 5 The Number output ");

            foreach (var x in listChanged5)
            {
                Console.WriteLine("the letter is " + x.letter + "  the frequence of it " + x.frequencyOfletter);
            }


            Console.WriteLine();
            Console.WriteLine(" ==============================================================");



            //task 6
            string[] list6 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var listChanged6 = list6.Select(Day => new { day = Day }).ToList();



            Console.WriteLine("Task 6 The Number output ");

            foreach (var x in listChanged6)
            {
                Console.WriteLine(x.day);
            }


            Console.WriteLine();
            Console.WriteLine(" ==============================================================");




            //task 7
            int[] list7 = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var listChanged7 = list7.Select(Number => new { number = Number, numberMultfrequencyofnum = (list7.Count(num => num == Number)) * Number, frequencyofNum = list7.Count(num => num == Number) }).ToList();



            Console.WriteLine("Task 7 The Number output ");

            foreach (var x in listChanged7)
            {
                Console.WriteLine("  " + x.number + "    " + x.numberMultfrequencyofnum + "    " + x.frequencyofNum);
            }


            Console.WriteLine();


            Console.WriteLine(" ==============================================================");



            //task8

            string[] list8 = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            //you can write ch1 and ch2 with console readline  abd input A and M
            char ch1 = 'A';
            char ch2 = 'M';

            var listChanged8 = list8.Where(City => City.StartsWith(ch1) && City.EndsWith(ch2)).Select(city => new { city, firletter = city[0], lastletter = city[city.Length - 1] });



            Console.WriteLine("Task 8 The Number output ");

            foreach (var x in listChanged8)
            {
                Console.WriteLine("The city Name is  " + x.city + "  The first letter is " + x.firletter + "  the last letter is " + x.lastletter);
            }


            Console.WriteLine();


            Console.WriteLine(" ==============================================================");






            //task9

            int[] list9 = { 55, 200, 740, 76, 230, 482, 95 };



            var listChanged9 = list9.Where(num => num > 80).ToList();



            Console.WriteLine("Task 9 The Number output :");

            foreach (var x in listChanged9)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine();


            Console.WriteLine(" ==============================================================");


            //task10
            int n = 0;
            List<string> numbersInput = new List<string>();

            Console.WriteLine("Member 0 :");
            string input = Console.ReadLine();
            numbersInput.Add(input);


            while (input != "")
            {
                Console.WriteLine("Member : " +( n+1));
               
                input = Console.ReadLine();
                n++;
                numbersInput.Add(input);
            }

            Console.WriteLine("Enter Required number: ");
            string inputreqNumb = Console.ReadLine();
            int numread;
            bool successread= int.TryParse(inputreqNumb, out numread);
            List<int> numbersInputChanged = new List<int>();


            for (int i = 0; i < numbersInput.Count; i++)
            {
                int number;
                

                
                bool success = int.TryParse(numbersInput[i], out number);

                if (success)
                {
                    numbersInputChanged.Add(number);
                }
                else
                { continue; }

            }

            Console.WriteLine("Task 10 The Number output :");

            var numbersInputChangedx2 = numbersInputChanged.Where(num => num > numread).ToList();

            foreach (int x in numbersInputChangedx2)
            {
                Console.WriteLine(x);
            }


        }

    }
}