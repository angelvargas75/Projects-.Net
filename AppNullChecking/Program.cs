class Person
{
    public string Name { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        Metodo1();
    }

    //Ejemplo de Null Pointer
    private static void Metodo1()
    {
        try
        {
            Person person = new Person();
            System.Console.WriteLine(person.Name.Length);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

    //Equality Operator ==    
    private static void Metodo2()
    {
        try
        {
            Person person = new Person();
            //Person person = new Person() { Name = "C#" };
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            System.Console.WriteLine(person.Name.Length);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

    //is Operator
    private static void Metodo3()
    {
        try
        {
            Person person = null;
            //Person person = new Person() { Name = "C#" };
            if (person is null)
                throw new ArgumentNullException(nameof(Person));

            Console.WriteLine(person.Name.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //Null-Coalescing Operator ??
    private static void Metodo4()
    {
        try
        {
            Person person = null;
            //Person person = new Person() { Name = "C#" };
            _ = person.Name ?? throw new ArgumentNullException();

            Console.WriteLine(person.Name.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //is object
    private static void Metodo5()
    {
        Person person = null;
        //Person person = new Person() { Name = "ANGEL" };
        if (person is object)
            System.Console.WriteLine(person.Name.Length);
        else
            System.Console.WriteLine("es null");
    }

    //! o not
    private static void Metodo6()
    {
        Person person = null;
        //Person person = new Person() { Name = "ANGEL" };

        //if (!(person is null))
        if (person is not null)
            System.Console.WriteLine(person.Name.Length);
        else
            System.Console.WriteLine("es null");
    }

    //Object.ReferenceEquals Method
    private static void Metodo7()
    {
        //Person person = null;
        //Person person = new Person() { Name = "ANGEL" };
        Person person = new Person();
        person.Name = null;

        if (object.ReferenceEquals(null, person) || object.ReferenceEquals(null, person?.Name))
            throw new ArgumentNullException();

        System.Console.WriteLine(person.Name.Length);
    }

    //Uso de extensiones
    /*private static void Metodo8()
    {
        try
        {
            Person person = new Person();
            person.Name = null;

            Console.WriteLine(person.Name.ThrowIfNull(nameof(person.Name)).Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR{Environment.NewLine}{ex}");
        }
    }*/
}


/*public static class NullCheckExtensions
{
    public static T ThrowIfNull(this T @object, string paramName = "") where T : class
    {
        if (@object == null)
        {
            if (!String.IsNullOrEmpty(paramName))
                throw new ArgumentNullException(paramName);

            throw new ArgumentNullException();
        }

        return @object;
    }
}*/