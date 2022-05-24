namespace Arv
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WindowWidth = 110;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Hello, This is a small program that shows the concept of inheritance, polymorhpsim and interface *");
            Console.WriteLine("****************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;

            Animal bird1 = new Swan(40, 130, "Swan1", 25, 5);
            Animal bird2 = new Flamingo(50, 150, "Flamingo1", 27, 4);
            Animal bird3 = new Pelican(25, 156, "Pelican1", 30, 6);
            Animal wolf1 = new Wolf("Brown", "Wolf1", 60, 10);
            Wolfman wolfman1 = new Wolfman("White", "Wolfman1", 85, 35);

            List<Animal> animals = new List<Animal>() { bird1, bird2, bird3, wolf1, wolfman1};

            foreach (Animal animal in animals)
            {
                if(animal.GetType() != typeof(Wolfman))
                {
                    Console.WriteLine();
                    Console.WriteLine(animal.Stats());
                    animal.DoSound();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(animal.Stats());
                    Wolfman wolfman2 = (Wolfman)animal;
                    wolfman2.Talk();
                }
            }

            Dog dog1 = new Dog("Bulldog", "Dog1", 25, 5);
            Dog dog2 = new Dog("Shepherd", "Dog2", 27, 4);
            Dog dog3 = new Dog("Retriever", "Dog3", 30, 6);
            Horse horse1 = new Horse(200, "Horse1", 60, 10);

            //9.  Den funkar inte pga klass-typen. Listan kan ta emot endast <Dog>
            //List<Dog> dogs = new List<Dog>() { dog1, dog2, dog3, horse1 };
            
            //10. Det kan funka om man skapar listan från klassen <Animal> 
            List<Animal> animals2 = new List<Animal>() { dog1, dog2, dog3, horse1 };
            
            Console.WriteLine();
            Console.WriteLine("***************** Animal list of dogs with a horse ************************");
            
            foreach (Animal animal in animals2)
            {
                Console.WriteLine();
                Console.WriteLine(animal.Stats());
                animal.DoSound();
            }

            List<Dog> dogs = new List<Dog>() { dog1, dog2, dog3 };

            Console.WriteLine();
            Console.WriteLine("*****************  List of dogs from the class dog *************************************");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine();
                Console.WriteLine(dog.Stats());
                dog.DoSound();
                dog.SpecialMethod(); // 16. Nej, jag kan inte komma åt denna metod
            }

            // 17. Eftersom listan tillhör klassen "Animal" och den har inte en declaration
            // till den speciala metoden.
            // 18. Man kan komma åt den genom att declarera denna metod i klassen "Animal" eller genom att 
            // byta listans typen till klassen "Dog"


            /*
            Console.WriteLine();
            Animal bird1 = new Swan(40, 130,"Swan1", 25, 5);
            Console.WriteLine(bird1.ToString());
            bird1.DoSound();

            Console.WriteLine();
            Animal bird2 = new Flamingo(50, 150, "Flamingo1", 27, 4);
            Console.WriteLine(bird2.ToString());
            bird2.DoSound();

            Console.WriteLine();
            Animal bird3 = new Pelican(25, 156, "Pelican1", 30, 6);
            Console.WriteLine(bird3.ToString());
            bird3.DoSound();

            Console.WriteLine();
            Wolfman animal4 = new Wolfman("White","Wolfman1", 85, 35);
            Console.WriteLine(animal4.ToString());
            animal4.Talk();
            */
        }
    }
}