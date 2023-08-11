using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates class Employee and creates new list employeelist
            List<Employee> employeeList = new List<Employee>();
            //inputs three properties for ten employees
            employeeList.Add(new Employee("Joe", " Biden", 1));
            employeeList.Add(new Employee("Hunter", " Biden", 2));
            employeeList.Add(new Employee("Joe", " Camel", 3));
            employeeList.Add(new Employee("Fresh", " Prince", 4));
            employeeList.Add(new Employee("Barack", " Obama", 5));
            employeeList.Add(new Employee("Muggsy", " Bogges", 6));
            employeeList.Add(new Employee("Wade", " Boggs", 7));
            employeeList.Add(new Employee("Joe", " Dirt", 8));
            employeeList.Add(new Employee("Mac", " Tonite", 9));
            employeeList.Add(new Employee("Joe", " Cool", 10));

            //creates second list to contain employees name Joe
            List<Employee> list2 = new List<Employee>();
            //foreach loop, creates new variable joe in employeelist
            foreach (var joe in employeeList)
            {   //if first name is Joe, adds to list2
                if (joe.FirstName == "Joe")
                {
                    list2.Add(joe);
                    //writes employees named Joe from list2
                    Console.WriteLine("These are the Joes I know: " + joe.FirstName + joe.LastName);
                }
            }
                
                //creates list newList using lambda expression that filters out employees with first name Joe
                List<Employee> newList = employeeList.Where(x => (x.FirstName == "Joe")).ToList();
                //foreach loop using newList
                foreach (Employee emp in newList)
                {
                    Console.WriteLine("Employees named Joe: " + emp.FirstName + emp.LastName);
                }
                //creates list newList2 using lambda expression that filters out employees with ID number greater than 5
                List<Employee> newList2 = employeeList.Where(x => x.ID > 5).ToList();
                //uses foreach loop on newList2 to print list of filtered employees
                foreach (Employee emp2 in newList2)
                {
                    Console.WriteLine("Employees with ID no. greater than 5: " + emp2.FirstName + emp2.LastName + ", " + emp2.ID);
                }
                Console.ReadLine();


            }

        }
    }

