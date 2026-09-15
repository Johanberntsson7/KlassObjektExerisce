namespace KlassObjektExerisce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Här skriver jag kommentarer
            // Jag har skapat en klass som heter Animal


            // Nemo sa att vi först ska göra en instans av en klass, jag testar så här
            Animal cat = new Animal();

            // Här vill jag att katten ska heta Sandra
            cat.name = "Sandra";
            cat.type = "Katt";

            // Jag vill dubbelkolla om den här katten verkligen heter Sandra, så jag skriver ut namnet
            Console.WriteLine($"Katten heter {cat.name} och är en {cat.type}");

            // Nu vill jag se katten springa, så jag anropar metoden run
            cat.run();

            Animal dog = new Animal();
            dog.name = "Bosse";
            dog.type = "Hund";
            Console.WriteLine($"Hunden heter {dog.name} och är en {dog.type}");

            // Nu vill jag se hunden springa, så jag anropar metoden run
            dog.run();
            

        }
    }

    public class Animal
    {
        public string name; 
        public string type;
        
        
        

        public void run() 
        {
            Console.WriteLine("Johan class exercise 1");
        }
    }
    
}