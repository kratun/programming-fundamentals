using System;

namespace DebitCardNumber
{
    class DebitCardNumbers
    {
        static void Main()
        {
            int firstFourDigits=int.Parse(Console.ReadLine());
            int secondFourDigits = int.Parse(Console.ReadLine());
            int thirdFourDigits = int.Parse(Console.ReadLine());
            int forthFourDigits = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstFourDigits:D4} {secondFourDigits:D4} {thirdFourDigits:D4} {forthFourDigits:D4}");
            
        }
    }
}