namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] cibiPreferiti = {
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
            if (cibiPreferiti.Length > 0)
            {
                // Stampa Lunghezza
                Console.WriteLine($"La classifica è lunga {cibiPreferiti.Length}");

                // Stampa Classifica
                for (int i = 0; i < cibiPreferiti.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {cibiPreferiti[i]}");
                }

                /* Stampa classifica alternativa
                 int posizione = 0;
                foreach (string cibo in  cibiPreferiti)
                {

                    Console.WriteLine($"{posizione+1} - {cibo}");
                    posizione++;
                } 
                */

                // Stampa Top
                Console.WriteLine($"Cibo preferito - {cibiPreferiti[0]}");

                // Stampa Coda
                Console.WriteLine($"Cibo poco preferito - {cibiPreferiti[cibiPreferiti.Length - 1]}");

                if (cibiPreferiti.Length % 2 == 0)
                {
                    // Se la lunghezza è pari, stampa i due elementi al centro
                    int centroIndex1 = cibiPreferiti.Length / 2 - 1;
                    int centroIndex2 = cibiPreferiti.Length / 2;
                    Console.WriteLine($"Cibo di mezza classifica: {cibiPreferiti[centroIndex1]} e {cibiPreferiti[centroIndex2]}");
                }
                else
                {
                    // Se la lunghezza è dispari, stampa solo l'elemento al centro
                    int centroIndex = cibiPreferiti.Length / 2;
                    Console.WriteLine($"Cibo di mezza classifica: {cibiPreferiti[centroIndex]}");
                }
            }
            else
            {
                Console.WriteLine("Non hai cibi preferiti!");
            }
        }
    }
}
