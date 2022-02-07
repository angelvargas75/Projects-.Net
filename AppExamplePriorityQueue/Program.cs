using System;
using System.IO.Pipes;
public class AppExamplePriorityQueue
{
    public static void Main(String[] args)
    {
        Console.WriteLine("----C#10 Priority Queue - Balta.io----");
        Example2();
    }

    //usando el ordenamiento Standar aplicado por .Net
    static void Example1()
    {
        var queue = new PriorityQueue<string, int>();

        queue.Enqueue("item 1", 0);
        queue.Enqueue("item 2", 4);
        queue.Enqueue("item 3", 2);
        queue.Enqueue("item 4", 1);

        while (queue.TryDequeue(out var item, out var priority))
        {
            System.Console.WriteLine($"Item: {item} \t Prioridade: {priority}");
        }
    }


    //usando un ordenamiento personalizado
    static void Example2()
    {
        var queue = new PriorityQueue<Student, string>(new RoleComparer());
        queue.Enqueue(new Student("Superman"), "student");
        queue.Enqueue(new Student("Iroman"), "premium");
        queue.Enqueue(new Student("Batman"), "admin");

        while (queue.TryDequeue(out var item, out var priority))
            System.Console.WriteLine($"Alumno: {item.Name} \t Prioridade: {priority}");
    }
}

public record Student(string Name);
public class RoleComparer : IComparer<string>
{
    public int Compare(string? roleA, string? roleB)
    {
        if (roleA == roleB)
            return 0;

        return roleA switch
        {
            "admin" => -1,
            "premium" => -1,
            _ => 1
        };
    }
}