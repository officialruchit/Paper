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
            printStatus printMessage=CheckStatusForPrinter(paperCount);
        Console.WriteLine(    getStatusmessage(printMessage));
        
        }
        public static string getStatusmessage(printStatus status) {
            switch (status) {
                case printStatus.NotReady:
                    return ($"{Environment.NewLine}  not ready");
                case printStatus.PrinterReady:
                 return($"{Environment.NewLine}  printer is ready");
                case printStatus.PaperLow:
                    return ($"{Environment.NewLine}  paper is low");
                case printStatus.Error:
                return($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");
                default:
                    return($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");

            }


        }
        public static int getValidateCount()
        {
            while (true)
            {
                Console.Write($"{Environment.NewLine}\u0020Enter the Paper Count[Range: 0 to 2147483647]: ");
                string count = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(count))
                {
                    Console.WriteLine($"{Environment.NewLine}\u0020Priner Status:[Error]Entered Paper count is invalid.");
                    continue;
                }
                if (!int.TryParse(count, out int PaperCount))
                {
                    Console.WriteLine($"{Environment.NewLine}\u0020Priner Status:[Error]Entered Paper count is invalid.");
                    continue;
                } 
                if (PaperCount < 0 || PaperCount > 2147483647)
                {
                    Console.WriteLine($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");
                    continue;
                }
                return PaperCount;
            }
        }
        public static printStatus CheckStatusForPrinter(int paperCount)
        {
            if (paperCount == 0)
            {
                /* return($"{Environment.NewLine}  not ready");*/
               return printStatus.NotReady;
            }
            if (paperCount > 0 && paperCount < 10)
            {
                /* return($"{Environment.NewLine}  paper is low");*/
                return printStatus.PaperLow;

            }
            if (paperCount > 10)
            {
                /* return($"{Environment.NewLine}  printer is ready");*/
                return printStatus.PrinterReady;
            }
            else
            {
                /* return($"{Environment.NewLine}  Priner Status:[Error]Entered Paper count is invalid.");*/
                return printStatus.Error;
            }
        }
    }
}