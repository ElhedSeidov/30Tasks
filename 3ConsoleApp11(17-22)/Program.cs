using System.Runtime.InteropServices;

namespace ConsoleApp11
{
    internal class Program
    {//task17
        static void Main(string[] args)
        {
            List<char> listOfString1 = new List<char>();
            listOfString1.Add('m');
            listOfString1.Add('n');
            listOfString1.Add('o');
            listOfString1.Add('p');
            listOfString1.Add('q');

            var listOfArray = listOfString1.Remove('o');

            foreach (var item in listOfString1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("================================================");

            //task18

            List<char> listOfString2 = new List<char>();
            listOfString2.Add('m');
            listOfString2.Add('n');
            listOfString2.Add('o');
            listOfString2.Add('p');
            listOfString2.Add('q');


            var listofArray2 = listOfString2.Where(x => x != 'p').ToList();

            foreach (var item in listofArray2)
            {
                Console.WriteLine(item);
            }

            //task19
            Console.WriteLine();
            Console.WriteLine("================================================");

            List<char> listOfString3 = new List<char>();
            listOfString3.Add('m');
            listOfString3.Add('n');
            listOfString3.Add('o');
            listOfString3.Add('p');
            listOfString3.Add('q');


            var listofArray3 = listOfString3.Where(x => x != 'q').ToList();

            foreach (var item in listofArray3)
            {
                Console.WriteLine(item);
            }


            //task20
            Console.WriteLine();
            Console.WriteLine("================================================");

            List<char> listOfString4 = new List<char>();
            listOfString4.Add('m');
            listOfString4.Add('n');
            listOfString4.Add('o');
            listOfString4.Add('p');
            listOfString4.Add('q');


            var listofArray4 = listOfString4.Remove(listOfString4.ElementAt(3));

            foreach (var item in listOfString4)
            {
                Console.WriteLine(item);
            }


            //task21
            Console.WriteLine();
            Console.WriteLine("================================================");

            List<String> listOfString5 = new List<String>();
            listOfString5.Add("m");
            listOfString5.Add("n");
            listOfString5.Add("o");
            listOfString5.Add("p");
            listOfString5.Add("q");

            int index5 = 2;
            int list5length = listOfString5.Count() - index5;

            listOfString5.RemoveRange(index5, list5length);

            foreach (var item in listOfString5)
            {
                Console.WriteLine(item);
            }


            //task22
            Console.WriteLine();
            Console.WriteLine("================================================");


            int n = 0; //task22
            List<string> Elements = new List<string>();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number1);


            Console.WriteLine("Element 0 :");
            string input = Console.ReadLine();
            Elements.Add(input);


            while (Elements.Count != number1)
            {
                Console.WriteLine("Element : " + (n + 1));

                input = Console.ReadLine();
                n++;
                Elements.Add(input);
            }
            Console.WriteLine("Input min num of chars in str ");
            bool b = int.TryParse(Console.ReadLine(), out int number2);

            var listofArray5 = Elements.Where(x => x.Length > number2).OrderBy(z => z.Length).Take(1);

            foreach (var item in listofArray5)
            {
                Console.WriteLine(item);
            }

       


            
    }
}