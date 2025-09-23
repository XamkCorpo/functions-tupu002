namespace FunctionAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this

            string name = "";
            int age = 0;
            bool valid = false;

            // Ask for name and ensure it is not empty

            AskName(ref name, ref valid);

            // Ask for age and ensure it is a positive integer

            valid = AskAge(ref age);

            // Print name and age
            PrintNameAndAge(name, age);

            // Check if the user is an adult
            CheckAdult(age);

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            CompareNames(name, compareName);
        }

        /// <summary>
        /// This function compares the user's name to a given name in both case-sensitive and case-insensitive ways.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareName"></param>
        private static void CompareNames(string name, string compareName)
        {
            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }

        /// <summary>
        /// This function checks if the user is an adult (18 or older) and prints a message accordingly.
        /// </summary>
        /// <param name="age"></param>
        private static void CheckAdult(int age)
        {
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
        }

        private static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// This function asks for the user's age until a valid positive integer is provided.
        /// </summary>
        /// <param name="age"></param>
        /// <returns>returns valid input</returns>
        private static bool AskAge(ref int age)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    valid = true;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }

            return valid;
        }

        /// <summary>
        /// This function asks for the user's name until a valid (non-empty) name is provided.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="valid">returns valid input</param>
        private static void AskName(ref string name, ref bool valid)
        {
            while (!valid)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    valid = true;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }
    }
}
