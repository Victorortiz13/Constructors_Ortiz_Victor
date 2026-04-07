namespace Constructors_Ortiz_Victor
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Creates a object and initilizes it and sets a value for the title and genre and replaces the original title and genre values
            Game fg = new Game("The Legend of Zelda: Breath of The Wild", "Open-world Action-adventure");
            // Prints the value set by the fg object title and genre into a sentance
            Console.WriteLine($"My favorite game is {fg.title} and it is a {fg.genre}!! So if you like it you should play it!");
            // Creates another object but doesn't set the values
            Game myOtherG = new Game();
            // Prints a sentance to the user with the myOtherG values that are default
            Console.WriteLine($"My other favorite game? It is a {myOtherG.title} and it is {myOtherG.genre}! You can know it, I left all the information in one place!");
        }
    }
}
