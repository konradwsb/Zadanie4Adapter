public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Enter the length of the square's side:");
            if (double.TryParse(Console.ReadLine(), out double side))
            {
                Square square = new Square(side);
                IShape adapter = new SquareAdapter(square);
                Console.WriteLine("Area of the square: " + adapter.GetArea());
            }
            else
            {
                Console.WriteLine("Invalid side length, please try again.");
            }

            Console.WriteLine("Do you want to enter another side? (yes/no)");
        } while (Console.ReadLine().ToLower() == "yes");
    }
}
