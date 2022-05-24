namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WindowWidth = 110;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Hello, This is a little program about Polymorfism *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            UserError numeric = new NumericInputError();           
            UserError text = new TextInputError();
        
            Console.WriteLine("**************** Numeric and Text Proogram ********************");
            Console.WriteLine();
            
            UserError[] userErrors = {text,numeric };
            foreach (UserError error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            Console.WriteLine();
            Console.WriteLine("********************* Vehicle Program *************************");
            Console.WriteLine();
     
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            List<Vehicle> vehicles = new List<Vehicle>() { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }
}