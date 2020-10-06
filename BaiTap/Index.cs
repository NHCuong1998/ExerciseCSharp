using System;
using System.Collections;
using System.Collections.Generic;

namespace BaiTap
{
    class Index
    {
        static List<Student> stu = new List<Student>();
        static List<Class> list = new List<Class>();
        static List<Student> stu1 = new List<Student>();
        static List<Class> list1 = new List<Class>();
        static void Main(string[] args)
        {

            stu.Add(new Student("Student001", "Student-I", Convert.ToDateTime("12/12/1997"), "Male", 10.0));
            stu.Add(new Student("Student002", "Student-II", Convert.ToDateTime("12/04/2005"), "Male", 7.2));
            stu.Add(new Student("Student003", "Student-III", Convert.ToDateTime("07/12/2003"), "Female", 6.3));

            list.Add(new Class("Java-I", "ClassJava", Convert.ToString(stu)));

            stu1.Add(new Student("Student004", "Student-I", Convert.ToDateTime("12/12/1998"), "Male", 10.0));
            stu1.Add(new Student("Student005", "Student-II", Convert.ToDateTime("08/03/1995"), "Female", 7.2));
            stu1.Add(new Student("Student006", "Student-III", Convert.ToDateTime("07/12/2003"), "Female", 6.3));

            list1.Add(new Class("C#-1", "ClassC#", Convert.ToString(stu1)));

            numberMenu();


        }
        static void numberMenu()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("--Enter 1 integer--");
            Console.WriteLine("1: Display information by class.");
            Console.WriteLine("2: List of students over 20 years old with GPA above 8.");
            Console.WriteLine("3: Find students by GPA.");
            Console.WriteLine("4: Find the student with the greatest GPA.");
            Console.WriteLine("5: Looking for female students.");
            Console.WriteLine("6: Find the class with the highest GPA.");
            Console.WriteLine("7: Exit the program.");
            Console.WriteLine("===========================");
            Console.Write("Enter: ");
            string number = Console.ReadLine();
            directional(number);

        }

        public static bool IsNumeric(string text)
        {
            return double.TryParse(text, out double test);
        }
        static void directional(string number)
        {

            if (IsNumeric(number) && Convert.ToInt32(number) > 0 && Convert.ToInt32(number) < 8)
            {
                switch (Convert.ToInt32(number))
                {
                    case 1:
                        sentenceA(stu, stu1);
                        break;
                    case 2:
                        sentenceB(stu, stu1);
                        break;
                    case 3:
                        sentenceC(stu, stu1);
                        break;
                    case 4:
                        sentenceD(stu, stu1);
                        break;
                    case 5:
                        sentenceE(stu, stu1);
                        break;
                    case 6:
                        sentenceF(stu, stu1);
                        break;
                    default:
                        Console.WriteLine("Invalid characters entered.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid characters entered.");
                numberMenu();

            }
        }

        static void reNumberMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("===========================");
            Console.WriteLine("--Enter 1 integer--");
            Console.WriteLine("1: Go back to the main menu.");
            Console.WriteLine("2: Exit the program.");
            Console.WriteLine("===========================");
            Console.Write("Enter: ");
            string number = Console.ReadLine();
            homeOrExit(number);

        }
        static void homeOrExit(string number)
        {
            if (IsNumeric(number) && Convert.ToInt32(number) > 0 && Convert.ToInt32(number) < 3)
            {
                switch (number)
                {
                    case "1":
                        numberMenu();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid characters entered.");
                        break;
                }
            }
            else
            {
                reNumberMenu();
            }
        }

        static void sentenceA(List<Student> stu, List<Student> stu1)
        {
            Console.WriteLine("");
            Console.WriteLine("---Classroom Java.---");
            foreach (var ls in stu)
            {
                Console.WriteLine(ls);
            }
            Console.WriteLine("");
            Console.WriteLine("---Classroom C#.---");
            foreach (var ls in stu1)
            {
                Console.WriteLine(ls);
            }
            reNumberMenu();
        }

        static void sentenceB(List<Student> stu, List<Student> stu1)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("---tudents who are older than 20 and have a GPA above 8.---");
            foreach (var ls in stu)
            {
                if ((date.Year - Convert.ToDateTime(ls.Dob).Year > 20) && (ls.Medium > 8))
                {
                    Console.WriteLine(ls);
                }
            }
            foreach (var ls in stu1)
            {
                if ((date.Year - Convert.ToDateTime(ls.Dob).Year > 20) && (ls.Medium > 8))
                {
                    Console.WriteLine(ls);
                }
            }
            reNumberMenu();
        }
        static void sentenceC(List<Student> stu, List<Student> stu1)
        {
            Console.Write("Enter 1 GPA: ");
            String gpa = Console.ReadLine();


            foreach (var ls in stu)
            {

                if (ls.Medium > Convert.ToDouble(gpa))
                {
                    Console.WriteLine(ls);
                }
            }
            foreach (var ls in stu1)
            {
                if (ls.Medium > Convert.ToDouble(gpa))
                {
                    Console.WriteLine(ls);
                }
            }
            reNumberMenu();
        }

        static void sentenceD(List<Student> stu, List<Student> stu1)
        {
            double max = 0;
            foreach (var ls in stu)
            {
                if (ls.Medium > max)
                {
                    max = ls.Medium;
                }
            }
            foreach (var ls in stu1)
            {
                if (ls.Medium > max)
                {
                    max = ls.Medium;
                }
            }
            foreach (var ls in stu)
            {
                if (ls.Medium == max)
                {
                    Console.WriteLine(ls);
                }
            }
            foreach (var ls in stu1)
            {
                if (ls.Medium == max)
                {
                    Console.WriteLine(ls);
                }
            }
            reNumberMenu();
        }

        static void sentenceE(List<Student> stu, List<Student> stu1)
        {
            foreach (var ls in stu)
            {
                if (ls.Dob.Month == 8 && ls.Dob.Day == 3 && ls.Gender.Equals("Female"))
                {
                    Console.WriteLine(ls);
                }
            }
            foreach (var ls in stu1)
            {
                if (ls.Dob.Month == 8 && ls.Dob.Day == 3 && ls.Gender.Equals("Female"))
                {
                    Console.WriteLine(ls);
                }
            }
            reNumberMenu();
        }
        static void sentenceF(List<Student> stu, List<Student> stu1)
        {
            double max = 0;
            Boolean? check = null;
            foreach (var ls in stu)
            {
                if (ls.Medium > max)
                {
                    max = ls.Medium;
                    check = false;
                }
                if (ls.Medium == max)
                {
                    max = ls.Medium;
                    check = null;
                }
            }
            foreach (var ls in stu1)
            {
                if (ls.Medium > max)
                {
                    max = ls.Medium;
                    check = true;
                }
                if (ls.Medium == max)
                {
                    max = ls.Medium;
                    check = null;
                }
            }

            if (check == null)
            {
                sentenceA(stu, stu1);
            }
            else if (check == true)
            {
                Console.WriteLine("---Classroom C#-1.---");
                foreach (var ls in stu1)
                {
                    Console.WriteLine(ls);
                }
            }
            else if(check == false)
            {
                Console.WriteLine("---Classroom Java-1.---");
                foreach (var ls in stu)
                {
                    Console.WriteLine(ls);
                }
            }
            reNumberMenu();
        }
    }
}
