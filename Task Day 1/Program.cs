
namespace Task_Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------------ Carpet cleaning services charges --------------------------
            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;
            double salesTaxRate = 0.06;

            Console.Write("what is the number of small carpets you want to be cleaned :");
            int smallCarpetsNum = int.Parse(Console.ReadLine());
            Console.Write("what is the number of large carpets you want to be cleaned :");
            int largeCarpetsNum = int.Parse(Console.ReadLine());

            int priceBeforeTax = (smallCarpetsNum * smallCarpetPrice) + (largeCarpetsNum * largeCarpetPrice);
            double taxAmount = priceBeforeTax * salesTaxRate;
            double priceAfterTax = priceBeforeTax + taxAmount;

            Console.WriteLine($"Price per small carpet is : {smallCarpetPrice}");
            Console.WriteLine($"Price per large carpet is : {largeCarpetPrice}");
            Console.WriteLine($"Coast is : {priceBeforeTax}");
            Console.WriteLine($"tax is : {salesTaxRate}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"total estimate is : {priceAfterTax}");
            Console.WriteLine("This estimate is valid for 30 days");


            //---------------------------------------Additional Using Standard Formating-------------------------------------
            Console.WriteLine("-----------------------Using Currency Format--------------------------");

            Console.WriteLine($"Price per small carpet is : {smallCarpetPrice:c1}");
            Console.WriteLine($"Price per large carpet is : {largeCarpetPrice:c1}");
            Console.WriteLine($"Coast is : {priceBeforeTax:c}");
            Console.WriteLine($"tax is : {salesTaxRate:p1}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"total estimate is : {priceAfterTax:c}");
            Console.WriteLine("This estimate is valid for 30 days");



            //------------------------------------------ Trying Of Search Task ----------------------------------

            int X = 10;
            int Y = 20;
            int z = X + Y;
            Console.WriteLine("X format integer as hexadecimal string");
            Console.WriteLine($"Equation: {X} + {Y} ==> {X + Y:x}");
            Console.WriteLine($"Using ToString 10 + 20 ==> {z.ToString("x")}");

            double examMark = 0.9655;
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("P format number in percentage format %");
            Console.WriteLine($"Mark is ==> {examMark:p2}");
            Console.WriteLine($"Using ToString ==> {examMark.ToString("P2")}");

            double num = 396.759;
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("F Display number in fixed number of decimal");
            Console.WriteLine($"Num is {num:f2}");
            Console.WriteLine($"Using ToString Num Is {num.ToString("f2")}");
            Console.ReadLine();
        }
    }
}
