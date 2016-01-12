using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StateId { get; set; }
    }

    class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
                                                        {
                                                            new Employee()
                                                            {
                                                                FirstName = "John",
                                                                LastName = "Smith",
                                                                StateId = 1
                                                            },
                                                            new Employee()
                                                            {
                                                                FirstName = "Jane",
                                                                LastName = "Doe",
                                                                StateId = 2
                                                            },
                                                            new Employee()
                                                            {
                                                                FirstName = "Jack",
                                                                LastName = "Jones",
                                                                StateId = 1
                                                            },
                                                            new Employee()
                                                            {
                                                                FirstName = "Sue",
                                                                LastName = "Smith",
                                                                StateId = 3
                                                            }
                                                        };
            List<State> states = new List<State>()
                                                        {
                                                            new State()
                                                            {
                                                            StateId = 1,
                                                            StateName = "PA"
                                                            },
                                                            new State()
                                                            {
                                                            StateId = 2,
                                                            StateName = "NJ"
                                                            }
                                                        };

            var employeeByState = from e in employees
                                  join s in states
                                  on e.StateId equals s.StateId
                                  select new { e.LastName, s.StateName };

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            }

            var employeeByStateI = from e in employees
                                   join s in states
                                   on e.StateId equals s.StateId into employeeGroup
                                   //from item in employeeGroup.DefaultIfEmpty(new State
                                   //                                                  {
                                   //                                                     StateId = 0,
                                   //                                                     StateName = ""
                                   //                                                  })
                                   from item in employeeGroup
                                   select new { item.StateId, item.StateName };
            
            //foreach (var employee in employeeByStateI)
            //{
            //    Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            //}
        }
    }
}
