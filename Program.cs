namespace Homework10;

internal class Program
{
    static void Main(string[] args)
    {
        Oceanarium oceanarium = new Oceanarium("Test Oceanarium", "Mushiv");
        oceanarium.AddInhabitant(new Inhabitant() { Name = "Shark", Age = 12 });
        oceanarium.AddInhabitant(new Inhabitant() { Name = "Dolphin", Age = 10 });
        oceanarium.AddInhabitant(new Inhabitant() { Name = "Jellyfish", Age = 5 });

        foreach (Inhabitant inhabitant in oceanarium)
        {
            Console.WriteLine(inhabitant);
        }
        
    }
}
