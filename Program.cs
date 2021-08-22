using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Point 

            Point p1 = new Point() { x = 10, y = 11, z = 12 };
            Point p2 = new Point() { x = 13, y = 14, z = 15 };
            Point p3 = new Point() { x = 16, y = 17, z = 18 };
            Point p4 = new Point() { x = 19, y = 20, z = 21 };
            Point[] points = { p1, p2, p3, p4 };
            Display(points);

            if (p1 == p2)
            {
                Console.WriteLine("Ref equals");
            }
            else
            {
                if (p1.Equals(p2))
                {
                    Console.WriteLine("Values equals");
                }
                else
                {
                    Console.WriteLine("Not equals");
                }

            }
            #endregion

            #region Collection
            Person [] people = { new Person() { Name = "Abdo", Age = 27 }, new Person() { Name = "Ahmed", Age = 28 }, new Person() { Name = "Abanoub", Age = 24 } };
            Empolyee[] empolyees = { new Empolyee() { Name = "EmAbdo", Age = 27 ,NID=45,Salary=15000}, new Empolyee() { Name = "EmAhmed", Age = 28,Salary=1600,NID=122 }, new Empolyee() { Name = "EmAbanoub", Age = 24, Salary = 1300, NID = 162 } };
            Trainee[] trainees = { new Trainee() { Name = "trAbdo", Age = 27 ,NID=45,IntakeNumber=5}, new Trainee() { Name = "trAhmed", Age = 28,IntakeNumber=1,NID=122 }, new Trainee() { Name = "trAbanoub", Age = 24, IntakeNumber = 1, NID = 162 } };
            
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (Empolyee empolyee in empolyees)
            {
                Console.WriteLine(empolyee.ToString());
            }
            foreach (Person trainee in trainees)
            {
                Console.WriteLine(trainee.ToString());
            }
             


            #endregion

            Console.ReadKey(); 
        }
        static  void Display(Point[] points)
        {
            foreach (Point point in points)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
