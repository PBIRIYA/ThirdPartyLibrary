using System;

namespace ThirdPartyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            CSVHandler.ImplimentatonDataHandling();
            //JSONcsvManipulation.ImplimentCSVtoJSON();
            JsonImplementation.ImplimentJSONtoCSV();
        }
    }
}