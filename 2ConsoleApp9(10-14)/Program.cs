namespace ConsoleApp9
{//11,12,13,14 tasks

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Grade { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)  //task11
        {
            var list1 = new List<int>()         
            { 1,2,5,4,9,12,4,3,55,31,21, };
            list1 =list1.OrderByDescending(x => x).Take(3).ToList();

            foreach(var x in list1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("==============================================================");

            string string2 = "this IS a STRING";//task12
            List<string> list2 = new List<string>();
            list2.AddRange(string2.Split(' '));

            list2 = list2.Where(x => x.All(z =>z==char.ToUpper(z))).ToList();

            foreach(var x in list2)
            {
                Console.WriteLine(x);

            }

            Console.WriteLine("==============================================================");
            int n = 0; //task13
            List<string> Elements = new List<string>();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(),out int number);


            Console.WriteLine("Member 0 :");
            string input = Console.ReadLine();
            Elements.Add(input);


            while (Elements.Count!=  number)
            {
                Console.WriteLine("Member : " + (n + 1));

                input = Console.ReadLine();
                n++;
                Elements.Add(input);
            }

            var ElementsChanged = String.Join(',', Elements);
            Console.WriteLine(ElementsChanged);


            Console.WriteLine("==============================================================");

            //task14

            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Grade = 21 },
            new Student() { StudentID = 2, StudentName = "Steve",  Grade = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Grade = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Grade = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Grade = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Grade = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Grade = 19  },
        };

            List<Student> Students = new List<Student>();

            Students.AddRange(studentArray);

            string c = Console.ReadLine();
            int s = int.Parse(c);

            var liststudents = Students.Where(x => x.Grade == Students.OrderByDescending(z => z.Grade).Skip(s - 1).Take(1).Select(f => f.Grade).ElementAt(0));

            foreach (var item in liststudents)
            {
                Console.WriteLine("ID :" + item.StudentID + "     " + item.StudentName + "       " + item.Grade);
            }


        }
    } 
}