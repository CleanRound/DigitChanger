internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a six-digit number:");
        if (int.TryParse(Console.ReadLine(), out int number) && IsSixDigitNumber(number))
        {
            Console.WriteLine("Enter two digits to replace:");
            if (int.TryParse(Console.ReadLine(), out int digit1) && int.TryParse(Console.ReadLine(), out int digit2))
            {
                int result = ReplaceDigits(number, digit1, digit2);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input for digits.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a six-digit number.");
        }
    }

    static bool IsSixDigitNumber(int num)
    {
        return num >= 100000 && num <= 999999;
    }

    static int ReplaceDigits(int num, int digit1, int digit2)
    {
        string numStr = num.ToString();
        char[] digits = numStr.ToCharArray();

        int index1 = digit1 - 1;
        int index2 = digit2 - 1;

        if (index1 >= 0 && index1 < 6 && index2 >= 0 && index2 < 6)
        {
            char temp = digits[index1];
            digits[index1] = digits[index2];
            digits[index2] = temp;

            return int.Parse(new string(digits));
        }
        else
        {
            Console.WriteLine("Error: Invalid digits.");
            return num;
        }
    }
}