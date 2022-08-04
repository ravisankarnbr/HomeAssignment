using DataApplication;
using DataApplication.Factory;

namespace DataProcessor
{
    class Program
    {
        private static void Main(string[] args)
        {
            var filePath = string.Empty;
            Console.Write("input data type : binary, text , textreverse\n\n");
            Console.Write("Please enter data type: ");
            string? val = Console.ReadLine();

            if (!string.IsNullOrEmpty(val))
            {
                Enum.TryParse(val.ToLower(), out FileType file);

                if (file == 0)
                {
                    Console.Write("Invalid data Type");
                }

                DataProcessorFactory factory = new ConcreteDataProcessor();
                IDataProcessor dp = factory.CreateDataProcessor(file);
                var data = dp.ProcessData();
                Console.Write($"Outpt:{data}");
            }


            Console.ReadLine();
        }
    }
}
