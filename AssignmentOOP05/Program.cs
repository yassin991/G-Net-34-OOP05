using AssignmentOOP05.simpleInterFace;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net;
using System.Security.AccessControl;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //        Q1: What is an interface in C#?  
            //            An interface in C# is a reference type that defines a contract.
            //It contains method signatures, properties, events, or indexers without implementation(by default).
            //A class that implements an interface must provide the implementation for all its members.
            //            Why do we use interfaces instead of depending on concrete classes directly?
            //                     We use interfaces to achieve loose coupling.
            //               At least Three Benefits of Using Interfaces
            //                  1.Loose Coupling
            //                  2.Polymorphism
            //                  3.Easier Testing 
            #endregion
            #region Q2
            //           a) What is the problem with this design?
            //            Both interfaces have a method called Greet() — how does the class handle it currently?
            //            contain a method with the same name and same signature.
            //            implements one single method that satisfies both interfaces.
            //                b) How would you fix this so each interface has its own implementation?
            //            class Translator : IEnglishSpeaker, IArabicSpeaker
            //        {
            //            void IEnglishSpeaker.Greet()
            //            {
            //                Console.WriteLine("Hello");
            //            }

            //            void IArabicSpeaker.Greet()
            //            {
            //                Console.WriteLine("Ahlan");
            //            }
            //        }
            //        It allows a class to provide separate implementations for interface members that have the same name.
            //            c) After applying the fix, can you call translator.Greet() directly?
            // No, you cannot.
            //Because explicit interface methods are not accessible through the class type directly 
            #endregion
            #region Q3
            //            3: Difference Between Shallow Copy and Deep Copy
            // 1) What is a Shallow Copy?
            //A shallow copy creates a new object, but copies the references of reference-type fields instead of creating new objects.
            //            Value types  copied normally
            //Reference types  only the reference is copied


            //    2) What is a Deep Copy?
            //A deep copy creates a completely new object and also creates new copies of all reference - type fields.
            //Value types → copied
            //Reference types → new separate objects are created



            //Risk of Using Shallow Copy
            //If the object has reference - type fields, both copies will share the same referenced object.

            //Risk:
            //Unexpected side effects
            //Data corruption
            //Bugs that are hard to detect 
            #endregion
            #region Q4
            //Q4: Look at the following code and determine the output.Explain why.

            //class Department { public string Name; }
            //        class Employee
            //        {
            //            public string Title;
            //            public Department Dept;
            //            public Employee ShallowCopy() => (Employee)this.MemberwiseClone();
            //        }

            //        var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            //        var e2 = e1.ShallowCopy();
            //        e2.Title = "QA";
            //e2.Dept.Name = "Testing";

            //Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
            //Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");

            //Output
            //Dev - Testing
            //QA - Testing

            //            Why?
            //Because:
            //Title is copied independently → changing e2.Title does NOT affect e1.Title.

            //Dept is a reference type → shallow copy copies the reference → both objects share the same Department instance.




            #endregion
            #region  Movie_Ticket 
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
            VIPTicket t2 = new VIPTicket("Avengers", 200, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine("--- Clone Test ---");

            VIPTicket clone = (VIPTicket)t2.Clone();
            clone.MovieName = "Interstellar";

            Console.Write("Original : ");
            t2.Print();

            Console.Write("Clone    : ");
            clone.Print();


            Console.WriteLine("\n--- After Cancellation ---");
            t1.Cancel();
            t1.Print();

            BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

            cinema.CloseCinema();
            #endregion
        }

    }
}

