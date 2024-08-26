namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
  
        static void Main()
        {
            // Call each method to test them
            PrintNumbers();
            PrintEveryThirdNumber();
            Console.WriteLine(AreNumbersEqual(5, 5));
            Console.WriteLine(IsEven(4));
            Console.WriteLine(IsPositive(-3));
            Console.WriteLine(CanVote(18));
            Console.WriteLine(IsInRange(5));
            DisplayMultiplicationTable(3);
        }

        // 1. Print all numbers from 1000 down to -1000
        static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Print every third number from 3 to 999
        static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Check if two integers are equal
        static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        // 4. Check if a number is even
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 5. Check if a number is positive
        static bool IsPositive(int number)
        {
            return number > 0;
        }

        // 6. Check if a candidate can vote
        static bool CanVote(int age)
        {
            return age >= 18;
        }

        // Heatin' Up Section:
        // 1. Check if a number is within the range -10 to 10
        static bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }

        // 2. Display the multiplication table for a given number
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
    }

}

