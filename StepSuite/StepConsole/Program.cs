using System;
using System.Text;     // << cần cho Encoding
using StepLib;

namespace StepConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Title = "Số Bước — Console (by Học)";
            Console.WriteLine("=== Hệ thống đo số bước đơn giản — Console ===");

            Console.Write("Quãng đường (km): ");
            string sKm = Console.ReadLine();
            Console.Write("Trọng lượng (kg): ");
            string sKg = Console.ReadLine();
            Console.Write("Chiều dài bước (m): ");
            string sStep = Console.ReadLine();

            StepCalculator sc = new StepCalculator();
            sc.DistanceKm = SafeParse.PositiveDouble(sKm);
            sc.WeightKg = SafeParse.PositiveDouble(sKg);
            sc.StepLengthM = SafeParse.PositiveDouble(sStep);
            sc.HocFactor = 1.0;
            sc.Signature = "by Học";

            Console.WriteLine();
            Console.WriteLine(sc.FormatResult());
            Console.WriteLine("Nhấn Enter để thoát...");
            Console.ReadLine();
        }
    }
}
