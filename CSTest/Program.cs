
using System;
namespace CSTest
{
    class Program
    {
        internal class Base1 : IComparable
        {
            // Explicit Interface Method Implementation
            Int32 IComparable.CompareTo(Object o)
            {
                Console.WriteLine("Base's CompareTo");
                return 0;
            }
        }

        internal sealed class Derived1 : Base1, IComparable
        {
            // A public method that is also the interface implementation
            public Int32 CompareTo(Object o)
            {
                Console.WriteLine("Derived's CompareTo");
                // This attempt to call the base class's EIMI causes a compiler error:
                // error CS0117: 'Base' does not contain a definition for 'CompareTo'
                //var x = base;

                return 0;
            }
        }

        public class Base
        {
            private Int32 test = 10;
            public Base()
            {
                test = 5;
            }

            public Int32 prova()
            {
                return test;
            }
        }

        public class Derived : Base
        { }

        class Person
        { }

        class Employee : Person
        { }

        class Manager : Employee
        { }

        static void Main(string[] args)
        {
            Base b = new Base();
            Console.WriteLine(b.prova());

            
            // Declare and initialize an array of Employees.
            Employee[] employees = new Employee[10];
            for (int id = 0; id < employees.Length; id++)
                employees[id] = new Employee();
            // Implicit cast to an array of Persons.
            // (An Employee is a type of Person.)
            Person[] persons = employees;
            // Explicit cast back to an array of Employees.


            // (The Persons in the array happen to be Employees.)
            employees = (Employee[])persons;
            // Use the is operator.
            if (persons is Employee[])
            {
                // Treat them as Employees.

            }
            // Use the as operator.
            employees = persons as Employee[];
            // After this as statement, managers is null.
            Manager[] managers = persons as Manager[];
            // Use the is operator again, this time to see
            // if persons is compatible with Manager[].
            if (persons is Manager[])
            {
                // Treat them as Managers.
                //...
            }
            // This cast fails at run time because the array
            // holds Employees not Managers.
            managers = (Manager[])persons;

            // IList<Base> baseArray = new Base[2];
            Base[] baseArray = new Base[2];

            // IList<Derived> derivedArray = new Derived[3];
            Derived[] derivedArray = new Derived[2];

            // T of IList<T> is invariant,
            // so logically binding IList<derivedArray> to IList<Base> could not be compiled.
            // But C# compiles it, to be compliant with Java :(
            baseArray = derivedArray; // Array covariance.

            // At runtime, baseArray refers to a Derived array.
            // So A Derived object can be an element of baseArray[0].
            baseArray[0] = new Derived();

            // At runtime, baseArray refers to a Derived array.
            // A Base object "is not a" Derivd object.
            // And ArrayTypeMismatchException is thrown at runtime.
            baseArray[1] = new Base();
        }
    }
}
