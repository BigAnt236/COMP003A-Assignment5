namespace COMP003A_Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Call PrintSeparator() with the parameter "Triangle"
            PrintSeparator("Triangle");

            // Request a single character input from the user
            Console.Write("Enter a character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());

            // Request a positive whole number input from the user
            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Call IsoscelesTriangleBuilder() with the user inputs as parameters
            IsoscelesTriangleBuilder(inputCharacter, size);

            // Call PrintSeparator() with the parameter "Favorite Characters"
            PrintSeparator("Favorite Characters");

            // Call CharacterInfo() at least 5 times with your favorite characters and their birth years
            CharacterInfo("Richard incognito", 1990);
            CharacterInfo("Alisson the great", 1985);
            CharacterInfo("Bob", 2000);
            CharacterInfo("Anthony", 1975);
            CharacterInfo("Chopper", 1995);
        }

        /// Outputs 50 asterisks to the console.
        static void PrintSeparator()
        {
            Console.WriteLine(new string('*', 50));
        }

        /// Outputs a string parameter and calls PrintSeparator().
        static void PrintSeparator(string text)
        {
            PrintSeparator();
            Console.WriteLine(text);
            PrintSeparator();
        }

        /// Builds an isosceles triangle using the specified character and size.
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i > 0; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// Calculates the age based on the specified birth year.
        static int AgeCalculator(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }

        /// Outputs a custom message about the character turning a specific age this year.
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }
    }
}
