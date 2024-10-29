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

        public class Student()
        {
            //zad2
            public string name { get; private set;}
            public int grade { get; private set;}

            public bool IsPassing()
            {
                if (grade != 1)
                {
                    Console.WriteLine("zdałeś koleś");
                    return true;

                }
                else
                {
                    Console.WriteLine("taktyczna pizda na koniec");
                    return false;
                }
            }
        }

        public static void Main(string[] args) { 
        
        }
    }
}
