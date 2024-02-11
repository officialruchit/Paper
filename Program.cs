namespace App
{
    public class Program { 
        
    
    public static void Main(string[] args) {
            Console.WriteLine("|======================================================|");
            Console.WriteLine("File Transfer Calculation ");
            Console.WriteLine("Transmission Rate:960 bytes/sec");
            Console.WriteLine("|======================================================|");
           

            double fileSize = ValidateFileSize();
            string fileUnit = ValidateFileUnit();
        }  

    public static double ValidateFileSize() {

            while (true)
            {

                Console.WriteLine("enter the size [range:0 to 2147483647]");
                string input=Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine("Entered file size is invalid.");
                    continue;
                   }
                if (!double.TryParse(input, out double fileSize)) {
                    Console.WriteLine("Entered file size is invalid.");
                    continue;
                }
                if (fileSize < 0 || fileSize > 2147483647) { 
                Console.WriteLine("Entered file size is out of the predefined range.");
                    continue;
                }


                return fileSize;    
            } 
        }
        
        public static string ValidateFileUnit() {



            while (true) {
                Console.Write("Enter the file size unit [B or KB or MB] : ");
                string fileUnit=Console.ReadLine().Trim().ToUpper();

                if (string.IsNullOrEmpty(fileUnit)) {
                    Console.WriteLine("Entered file size is invalid.");
                    continue;
                }
                if (!IsFileUnit(fileUnit))
                {
                    Console.WriteLine("Entered file size is invalid.");
                    continue;
                }
                return fileUnit;
            }
        }
    public static bool IsFileUnit(string unit)
        {
            return unit == "B" || unit == "KB"|| unit == "MB";
        }
    }

}





/*using System;

namespace FileTransferTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|=================================================================|");
            Console.WriteLine("\tFILE TRANSFER TIME CALCULATION");
            Console.WriteLine("\tTransmission rate: 960 bytes/sec");
            Console.WriteLine("|=================================================================|");
            Console.WriteLine();

            // Get file size and its unit from the user
            double fileSize = GetValidatedFileSize();
            string fileSizeUnit = GetValidatedFileSizeUnit();

            // Convert file size to KB
            fileSize = ConvertFileSizeToKB(fileSize, fileSizeUnit);

            // Calculate transfer time
            TimeSpan transferTime = CalculateTransferTime(fileSize);

            // Display the result
            DisplayResult(transferTime);
        }

        static double GetValidatedFileSize()
        {
            while (true)
            {
                Console.Write("Enter the file size [Range: 0 to 2147483647] : ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out double fileSize) || fileSize < 0 || fileSize > 2147483647)
                {
                    Console.WriteLine("Error: Entered file size is invalid.");
                    Console.WriteLine("Please enter a valid positive number.");
                    continue;
                }

                return fileSize;
            }
        }

        static string GetValidatedFileSizeUnit()
        {
            while (true)
            {
                Console.Write("Enter the file size unit [B or KB or MB] : ");
                string fileSizeUnit = Console.ReadLine().Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(fileSizeUnit) || !IsValidFileSizeUnit(fileSizeUnit))
                {
                    Console.WriteLine("Error: Entered file size unit is invalid.");
                    Console.WriteLine("Please enter a valid unit (B, KB, or MB).");
                    continue;
                }

                return fileSizeUnit;
            }
        }

        static bool IsValidFileSizeUnit(string unit)
        {
            return unit == "B" || unit == "KB" || unit == "MB";
        }

        static double ConvertFileSizeToKB(double size, string unit)
        {
            switch (unit)
            {
                case "B":
                    return size / 1024.0;
                case "MB":
                    return size * 1024.0;
                default:
                    return size;
            }
        }

        static TimeSpan CalculateTransferTime(double fileSizeInKB)
        {
            int transmissionRate = 960; // bytes/sec
            double fileSizeInBytes = fileSizeInKB * 1024; // Convert KB to bytes
            double transferTimeInSeconds = fileSizeInBytes / transmissionRate;
            return TimeSpan.FromSeconds(transferTimeInSeconds);
        }

        static void DisplayResult(TimeSpan transferTime)
        {
            Console.WriteLine("|======================================================9===========|");
            Console.WriteLine("\tCALCULATION RESULT");
            Console.WriteLine("|=================================================================|");
            Console.WriteLine("File transfer time calculation operation completed successfully.");
            Console.WriteLine($"Total time required to transfer file: ");
            Console.WriteLine($"\tDays:\t\t{transferTime.Days}");
            Console.WriteLine($"\tHours:\t\t{transferTime.Hours}");
            Console.WriteLine($"\tMinutes:\t{transferTime.Minutes}");
            Console.WriteLine($"\tSeconds:\t{transferTime.Seconds}");
            Console.WriteLine($"\tMilliseconds:\t{transferTime.Milliseconds}");
            Console.WriteLine();
        }
*//*    }*//*
}
*/