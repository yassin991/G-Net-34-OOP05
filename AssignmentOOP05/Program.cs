using System.ComponentModel;
using System.Diagnostics.Metrics;
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

        }
    }
}
