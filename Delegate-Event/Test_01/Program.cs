public class SamplesDelegate
{
    public delegate string myMethodDelegate(int myInt);

    public class mySampleClass
    {
        public string myStringMethod(int myInt)
        {
            if (myInt > 0) return "positive";
            if (myInt < 0) return "negative";
            return "Zero";
        }

        public static string mySignMethod(int myInt)
        {
            if (myInt > 0) return "+";
            if (myInt < 0) return "-";
            return "";
        }
    }

    public static void Main()
    {
        mySampleClass mySC = new mySampleClass();
        myMethodDelegate myD1 = new myMethodDelegate(mySC.myStringMethod);
        myMethodDelegate myD2 = new myMethodDelegate(mySampleClass.mySignMethod);

        System
            .Console
            .WriteLine("{0} is {1}; use the sign \"{2}\".",
            5,
            myD1(5),
            myD2(5));
        Console
            .WriteLine("{0} is {1}; use the sign \"{2}\".",
            -3,
            myD1(-3),
            myD2(-3));
        Console
            .WriteLine("{0} is {1}; use the sign \"{2}\".",
            0,
            myD1(0),
            myD2(0));
    }
}
