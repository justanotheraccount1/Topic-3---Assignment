namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/10/24
            int roomNumber = 29;
            double price = 2.99;
            string course = "Computer Science";
            string name = "Sam Ahrens";
            int gradYear = 2026;
            double radius = 10; //cm
            double area = (radius * radius) * 3.14159;

            Console.WriteLine("Welcome to room #" + (roomNumber) + "!");
            Console.WriteLine();
            Console.WriteLine("The price is :$" + (price));
            Console.WriteLine();
            Console.WriteLine("I am learning a bit about " + (course) + "!");

            Console.WriteLine();
            Console.WriteLine("Hi my name is " + name + ", and I will " +
                "graduate in " + gradYear + ".");
            Console.WriteLine();

            Console.WriteLine("If the radius of the circle is " + radius + "cm, the area will be " + area + "cm squared.");
        }
    }
}
