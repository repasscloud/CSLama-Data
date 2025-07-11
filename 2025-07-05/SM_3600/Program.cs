
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace SM_3600.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            SM_3600.ModelInput sampleData = new SM_3600.ModelInput()
            {
                User_Input = @"Can I scratch my hotel reservation due to unforeseen event?",
            };


            Console.WriteLine("Using model to make single prediction -- Comparing actual Classification with predicted Classification from sample data...\n\n");


            Console.WriteLine($"Classification: {@"ExistingBooking_CancelBooking"}");
            Console.WriteLine($"User_Input: {@"Can I scratch my hotel reservation due to unforeseen event?"}");


            var sortedScoresWithLabel = SM_3600.PredictAllLabels(sampleData);
            Console.WriteLine($"{"Class",-40}{"Score",-20}");
            Console.WriteLine($"{"-----",-40}{"-----",-20}");

            foreach (var score in sortedScoresWithLabel)
            {
                Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
            }
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
