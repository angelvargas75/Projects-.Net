using System;
using System.Linq;

namespace EFBasicTutorial2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test02();
            Console.ReadKey();
        }

        private static void Test02()
        {
            using (var context = new NorthwindEntities())
            {
                context.Database.Log = Logger.Log;

                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var order = context.Orders.Add(new Order() { CustomerID = "CENTC", EmployeeID = 7 });
                        context.Order_Details.Add(new Order_Detail()
                        {
                            OrderID = order.OrderID,
                            ProductID = 14,
                            UnitPrice = 18.99m,
                            Quantity = 5,
                            Discount = 0
                        });

                        context.SaveChanges();

                        //lanza una exception y hace rollback
                        throw new Exception();

                        context.Products.Add(new Product() { ProductName = "NUEVO PRODUCTO de Mierda" });
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred: " + e);
                    }
                }
            }
        }

        private static void Test01()
        {
            using (var context = new NorthwindEntities())
            {
                context.Database.Log = Logger.Log;

                var res = context.Products.Where(a => a.UnitsInStock > 50 && a.UnitPrice > 20).ToList();
                int count = 0;
                foreach (var item in res)
                {
                    Console.WriteLine($"{item.ProductID}  {item.ProductName}  {item.UnitsInStock}  {item.UnitPrice}");
                    count++;
                }
                Console.WriteLine("Numero de registros {0}", count);
                //context.SaveChanges();
            }
        }
    }


    //new class for Log
    class Logger
    {
        public static void Log(string msg)
        {
            Console.WriteLine("EF Message: " + msg);
        }
    }
}
