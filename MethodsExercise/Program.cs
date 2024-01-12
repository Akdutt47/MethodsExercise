namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();
            Console.WriteLine(Add(5, 5));
        }
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");
            Console.WriteLine("Your favorite color?");
            string? color = Console.ReadLine();
            Console.WriteLine($"{color}.");
            Console.WriteLine("Your favorite animal?");
            string? animal = Console.ReadLine();
            Console.WriteLine($"{animal}.");
            Console.WriteLine("Your favorite band?");
            string? band = Console.ReadLine();
            Console.WriteLine($"{band}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"My name is {name}, and my favorite color is {color}. I once had a pet {animal} that could dance to the music of {band}. It was a wild and colorful experience!");
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static void Subtract(int num1, int num2)
        {
            int answer = num1 - num2;
            Console.WriteLine({ answer});
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
