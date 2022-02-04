using System;
using ConsoleApp_MLNetML.Model;


namespace ConsoleApp.MLNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Add input data
            var input = new ModelInput();
            input.SentimentText = "Tat is cool"; //or Tat is cool
            
            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            var res = result.Prediction;

            //El resultado verdadero (1) significa que es toxico y falso (0) que no es toxico
            if (res.Equals("1")) Console.WriteLine("Es toxico");
            else Console.WriteLine("No es toxico");
        }
    }
}
