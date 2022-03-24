using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test01();
        }

        public static void Test01()
        {
            using (var context = new SchoolDBEntities())
            {
                
            }
        }
    }
}
