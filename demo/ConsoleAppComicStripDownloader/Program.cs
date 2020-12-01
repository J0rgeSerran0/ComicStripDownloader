using ComicStripDownloader;
using System;
using System.Threading.Tasks;

namespace ConsoleAppComicStripDownloader
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var service = new ComicStripService();
            var response = new ComicStripResponse("");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Dilbert");
            Console.ResetColor();
            // Dilbert
            Console.WriteLine("Getting the last Dilbert Comic Strip...");
            response = await service.GetLastComicStripUrlAsync(ComicStripType.Dilbert);
            PrintResult(response);
            Console.WriteLine("Getting the Dilbert Comic Strip of [2020/09/25]...");
            response = await service.GetComicStripUrlAsync(new DateTime(2020, 9, 25), ComicStripType.Dilbert);
            PrintResult(response);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Frank and Ernest");
            Console.ResetColor();
            // Frank and Ernest
            Console.WriteLine("Getting the last Frank and Ernest Comic Strip...");
            response = await service.GetLastComicStripUrlAsync(ComicStripType.FrankAndErnest);
            PrintResult(response);
            Console.WriteLine("Getting the Frank and Ernest Comic Strip of [2020/09/25]...");
            response = await service.GetComicStripUrlAsync(new DateTime(2020, 9, 25), ComicStripType.FrankAndErnest);
            PrintResult(response);

            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        private static void PrintResult(ComicStripResponse response)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (response.HasErrors)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(response.ErrorDescription);
            }
            else
                Console.WriteLine(response.Source);

            Console.ResetColor();
        }
    }
}