using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace App.InmediateVSExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Deferred execution");
            Metodo1();
            System.Console.WriteLine("Inmediate execution");
            Metodo2();
        }

       
        public static void Metodo1()
        {
            var list = new List<Employee>(new Employee[]{
                new Employee{ Emp_ID=1, Name="A"},
                new Employee{ Emp_ID=2, Name="B"},
                new Employee{ Emp_ID=3, Name="C"},
                new Employee{ Emp_ID=4, Name="D"},
                new Employee{ Emp_ID=5, Name="E"}
            });
            var res = from r in list select new { r.Emp_ID, r.Name };
            list.Add(new Employee { Emp_ID = 6, Name = "H" });
            list.Add(new Employee { Emp_ID = 7, Name = "I" });
            foreach (var item in res)
            {
                System.Console.WriteLine(item.Emp_ID + " - " + item.Name);
            }
        }

        public static void Metodo2()
        {
            var list = new List<Employee>(new Employee[]{
                new Employee{ Emp_ID=1, Name="A"},
                new Employee{ Emp_ID=2, Name="B"},
                new Employee{ Emp_ID=3, Name="C"},
                new Employee{ Emp_ID=4, Name="D"},
                new Employee{ Emp_ID=5, Name="E"}
            });
            var res = from r in list.ToList() select new { r.Emp_ID, r.Name };
            list.Add(new Employee { Emp_ID = 6, Name = "H" });
            list.Add(new Employee { Emp_ID = 7, Name = "I" });
            foreach (var item in res)
            {
                System.Console.WriteLine(item.Emp_ID + " - " + item.Name);
            }
        }
    }
}
