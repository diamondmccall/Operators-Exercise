namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //excercise1//

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radis of your circle?");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCirle(radius));
        }

        public static double AreaOfCirle(double radius)


        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;

            Console.WriteLine("What is the radius of the cirle?");

        }

        }
    }

