namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 step 1
            int a = 10;
            int b = 2;
            
            int added = a + b;
            int subtract = a - b;
            int mult = a * b;

            //Exercise 1 step 2

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} = {quotient} remainder {remainder}.");

            PrintAreaofCircle();
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaofCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double userRadius = double.Parse(Console.ReadLine());
            double areaOfUserCircle = AreaOfCircle(userRadius);
            Console.WriteLine($"The area of a circle with a radius of {userRadius} is {areaOfUserCircle}");



        }
    }
}
