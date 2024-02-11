namespace App
{
    public class Program
    {
        public enum printStatus { 
        NotReady,
        PaperLow,
        PrinterReady,
        Error
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("|===============================================|");
            Console.WriteLine("  printer status check");
            Console.WriteLine("|===============================================|");
            int paperCount = getValidateCount();
            printStatus printMessage = CheckStatusForPrinter(paperCount);  
            Console.WriteLine(getStatusmessage(printMessage));
        }
        public static int getValidateCount()
        {
            while (true)
            {
                Console.Write($"{Environment.NewLine}  Enter the Paper Count[Range: 0 to 2147483647]: ");
                string count = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(count))
                {
                    Console.WriteLine($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");
                    continue;
                }
                if (!int.TryParse(count, out int PaperCount))
                {
                    Console.WriteLine($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");
                    continue;
                } 
                if (!CheckrangeForCount(PaperCount))
                {
                    Console.WriteLine($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");
                    continue;
                }
                return PaperCount;
            }
        }
        public static bool CheckrangeForCount(int papaerCount) {
            if (papaerCount < 0 || papaerCount > 2147483647) { 
            return false;
            }
            return true;
        }


        public static printStatus CheckStatusForPrinter(int paperCount)
        {
            if (paperCount == 0)
            {
               return printStatus.NotReady;
            }
            if (paperCount > 0 && paperCount < 10)
            { 
                return printStatus.PaperLow;

            }
            if (paperCount > 10)
            {  
                return printStatus.PrinterReady;
            }
            else
            {   
                return printStatus.Error;
            }
        }
        public static string getStatusmessage(printStatus status)
        {
            switch (status)
            {
                case printStatus.NotReady:
                    return $"{Environment.NewLine}  \"not ready\"";
                case printStatus.PrinterReady:
                    return ($"{Environment.NewLine}  \"printer is ready\"");
                case printStatus.PaperLow:
                    return ($"{Environment.NewLine}  \"paper is low\"");
                case printStatus.Error:
                    return ($"{Environment.NewLine}  \"Priner Status:[Error]Entered Paper count is invalid.\"");
                default:
                    return ($"{Environment.NewLine}  \"Priner Status:[Error]Entered Paper count is invalid.\"");
            }
        }
    }
}