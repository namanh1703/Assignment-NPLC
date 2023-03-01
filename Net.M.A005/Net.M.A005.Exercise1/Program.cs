using System.ComponentModel.Design;

namespace Net.M.A005.Exercise1
{
    /// <summary>
    /// Write code to convert number from base 10 to base 2 (natural number to binary number)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            //InputNaturalNumber(x);
            ConvertToBinary(x);
        }
        /// <summary>
        /// Convert number from base 10 to base 2
        /// </summary>
        /// <param name="x"></param>
        static void ConvertToBinary(int x)
        {
            string Result = string.Empty;
            for (int i = 0; x > 0; i++)
            {
                Result = x % 2 + Result;
                x = x / 2;
            }
            Console.WriteLine("Natural number to binary number is : " + Result);
        }
        static int InputNaturalNumber()
        {
            int naturalNumber = default;
            bool checkResult = default;
            do
            {
                //User enter number/string
                Console.Write("Enter the Natural Number: ");
                
                String input = Console.ReadLine();
                //check number is natural
                checkResult = CheckNaturalNumber(input);
                //If yes, return number
                if (checkResult)
                {
                    naturalNumber = int.Parse(input);
                }
            } while (!checkResult);
            //if No, re-enter number/string
            return naturalNumber;
        }
        private static bool CheckNaturalNumber(string? input)
        {
            throw new NotImplementedException();
        }
    }
}
