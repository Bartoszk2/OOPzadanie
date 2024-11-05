namespace Exercises_Basics
{
    internal class Program
    {
        public class CAR()
        {

            //zad 1
            public string brand;
            public string Model;
            public DateOnly Production_date;

            public void Display_Info()
            {
                Console.WriteLine(brand);
                Console.WriteLine(Model);
                Console.WriteLine(Production_date);
            }
        }

        public class Student(string name, int grade)
        {
            //zad 2
             public bool IsPassing()
             {
                return grade != 1;

             }
        
        }

        public class book()
        {
            public string Title { get; private set; }
            public string Author { get; private set; }
            public int Pages { get; private set; }

            public void GetSummary()
            {

            }
        }

        public static void Main(string[] args)
        { 
        
        }
    }
}
