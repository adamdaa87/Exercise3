namespace Inkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 110;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Hej, det här ett litet program som hjälper att skapa personer *");
            Console.WriteLine("*****************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*
            try
            {
                Person person = new Person("Adam", "Daa");
                person.Height = 175;
                person.Weight = -85;
                person.Age = 35;

                Console.WriteLine(person.ToString());
            }
            catch(ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            */

            PersonHandler personHandler = new PersonHandler();
            try
            {
                personHandler.AddPerson(personHandler.CreatePerson("Adam", "Daa", 175, 85, 35));
                Console.WriteLine();
                personHandler.AddPerson(personHandler.CreatePerson("David", "Nokto"));
                personHandler.SetAge(personHandler.GetPerson(1), 33);
                personHandler.SetHeightAndWeight(personHandler.GetPerson(1), 177, 80);
                Console.WriteLine();
                personHandler.PrintOutPeople();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Exception: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}