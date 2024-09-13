using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(EF_Demo_Entities entities=new EF_Demo_Entities())
            {
                List<Department> departmentList = entities.Departments.ToList();
                Console.WriteLine();
                foreach(Department department in departmentList)
                {
                    Console.WriteLine($"  Department = {department.Name}, Location = {department.Location}");
                    foreach(Employee employee in department.Employees)
                    {
                        Console.WriteLine($"\t Name = {employee.Name}, Email = {employee.Email}, Gender = {employee.Gender}, salary = {employee.Salary}");


                          
                    }
                    Console.WriteLine() ;
                }
                Console.ReadKey();
            }
        }
    }
}
