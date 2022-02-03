using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo4();
            Metodo5();
            Console.ReadLine();
        }

        public static void Metodo3()
        {
            var fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Bilberry");
            fruits.Add("Blackberry");
            fruits.Add("Blackcurrant");
            fruits.Add("Blueberry");
            fruits.Add("Cherry");
            fruits.Add("Coconut");
            fruits.Add("Cranberry");
            fruits.Add("Date");
            fruits.Add("Fig");
            fruits.Add("Grape");
            fruits.Add("Guava");
            fruits.Add("Jack-fruit");
            fruits.Add("Kiwi fruit");
            fruits.Add("Lemon");
            fruits.Add("Lime");
            fruits.Add("Lychee");
            fruits.Add("Mango");
            fruits.Add("Melon");
            fruits.Add("Olive");
            fruits.Add("Orange");
            fruits.Add("Papaya");
            fruits.Add("Plum");
            fruits.Add("Pineapple");
            fruits.Add("Pomegranate");
            Console.WriteLine("Printing list using foreach loop\n");
            var stopWatch = Stopwatch.StartNew();
            // con bucle Foreach
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("foreach loop execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);
            Console.WriteLine("Printing list using Parallel.ForEach");

            //con bucle Parallel.ForEach
            stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(fruits, fruit =>
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);

            }
            );
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", stopWatch.Elapsed.TotalSeconds);
            Console.Read();
        }

        public static void Metodo4()
        {
            var stopWatch = Stopwatch.StartNew();
            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);
            foreach (string file in Directory.GetFiles(@"D:\Images"))
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(file);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font arialFont = new Font("Arial", 10))
                    {
                        graphics.DrawString("Banketeshvar", arialFont, Brushes.Blue, firstLocation);
                        graphics.DrawString("Narayan", arialFont, Brushes.Red, secondLocation);
                    }
                }
                bitmap.Save(Path.GetDirectoryName(file) + "Foreachloop" + "\\" + Path.GetFileNameWithoutExtension(file) + Guid.NewGuid()
                    .ToString() + ".jpg");
            }
            Console.WriteLine("foreach loop execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);
        }
        public static void Metodo5()
        {
            var stopWatch = Stopwatch.StartNew();
            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);
            Parallel.ForEach(Directory.GetFiles(@"D:\Images"), file =>
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(file);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font arialFont = new Font("Arial", 10))
                    {
                        graphics.DrawString("Banketeshvar", arialFont, Brushes.Blue, firstLocation);
                        graphics.DrawString("Narayan", arialFont, Brushes.Red, secondLocation);
                    }
                }
                bitmap.Save(Path.GetDirectoryName(file) + "Parallel" + "\\" + Path.GetFileNameWithoutExtension(file) + Guid.NewGuid()
                    .ToString() + ".jpg");
            });
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", stopWatch.Elapsed.TotalSeconds);
            Console.Read();
        }
    }
}
