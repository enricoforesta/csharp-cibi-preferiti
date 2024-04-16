namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Cibipreferiti = {
                "Pizza Margherita",
                "Lasagne",
                "Pasta al pesto",
                "Sushi",
                "Gelato alla stracciatella",
                "Insalata di quinoa",
                "Pollo al curry",
                "Tiramisù",
                "Ramen",
                "Tacos" 
             };
            Console.WriteLine($"la classifica è lunga {Cibipreferiti.Length}");
            for( int i = 0; i < Cibipreferiti.Length; i++ )
            {
                Console.WriteLine($"{i+1} - {Cibipreferiti[i]}");
            }
            Console.WriteLine($"Cibo preferito - {Cibipreferiti[0]}");
            Console.WriteLine($"Cibo poco preferito - {Cibipreferiti[Cibipreferiti.Length - 1]}");
        }
    }
}
