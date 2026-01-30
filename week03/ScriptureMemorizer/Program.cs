using System;
using System.Runtime.CompilerServices;

// To show creativity, I executed the program so that it randomly selects from only those words that are not already hidden.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        //Display the complete scripture
        Console.WriteLine($"{reference.GetDisplayText()}; {scripture.GetDisplayText()}");

        // Hide ramdom words
        while (true)
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string userResponse = Console.ReadLine();
            
            if (userResponse == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWord(3);

                //Clear the console
                Console.Clear();
                
                //Display the scripture text with missing words represented with "_ _ _"
                Console.WriteLine($"{reference.GetDisplayText()}; {scripture.GetDisplayText()}");
                if (scripture.IsCompletelyHidden())
                {
                    break;
                } 
            }
        }

        

        Reference reference1 = new Reference("John", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "5 Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God. 6 That which is born of the flesh is flesh; and that which is born of the Spirit is spirit.");
        Console.WriteLine(reference1.GetDisplayText2());
     
        //Display the complete scripture
        Console.WriteLine($"{reference1.GetDisplayText()}; {scripture1.GetDisplayText()}");

        while (true)
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string userResponse = Console.ReadLine();
            
            if (userResponse == "quit")
            {
                break;
            }
            else
            {
                scripture1.HideRandomWord(3);

                //Clear the console
                Console.Clear();
                
                //Display the scripture text with missing words represented with "_ _ _"
                Console.WriteLine($"{reference1.GetDisplayText2()}; {scripture1.GetDisplayText()}");
                if (scripture1.IsCompletelyHidden())
                {
                    break;
                } }
          }  }
}