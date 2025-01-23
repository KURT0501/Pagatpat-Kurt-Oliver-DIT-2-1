using cmd;
using pagatpat;
using System.Numerics;
namespace pagatpat

{
    internal class Program
    {

        static void Main(string[] args)

        {
            Data data = new Data ();
            List<PAGATPAT> PAGATPATS = data.Table_1();
            foreach (var PAGATPAT in PAGATPATS)
            {
                Console.WriteLine($"name: {PAGATPAT.Name}");
            }

            //filter
            List <PAGATPAT> artist = PAGATPATS.Where(x => x.artistName == "Alyda Cino").ToList();
                Console.WriteLine($"number of artist name is {artist.Count}");
            foreach (var PAGATPAT in artist)
            {
                Console.WriteLine( $"list of name: {artist}");
            }

            //order by
            List<PAGATPAT> artistLanguage = PAGATPATS.OrderBy(x => x.artistLanguage).ToList();
            foreach (var artistNames in artistLanguage)
            {
                Console.WriteLine($"list of languauge: {artistNames.artistLanguage}");
            }

            //Group
            var grouped = PAGATPATS.GroupBy(x => x.artistName);
            foreach (var PAGATPAT in grouped)
            {
                Console.WriteLine($"List of alphabethical name:{PAGATPAT.Key}");
            }
































            //    artist artista1 = new artist();
            //    artista1.artistName = "boy abunda";
            //    artista1.artistLanguage = "bisaya";
            //    artista1.companyName = "ABS";


            //    artist artista2 = new artist();
            //    artista2.artistName = "kathryn bernardo";
            //    artista2.artistLanguage = "ilonggo";
            //    artista2.companyName = "ABS";

            //    artist artista3 = new artist();
            //    artista3.artistName = "vice ganda";
            //    artista3.artistLanguage = "tagalog";
            //    artista3.companyName = "ABS";

            //    List<artist> program = new List<artist>();

            //    program.Add(artista1);
            //    program.Add(artista2);
            //    program.Add(artista3);

            //    foreach (var artist in program)
            //    {
            //        Console.WriteLine($"artist name: {artist.artistName}");
            //        Console.WriteLine($"artist cost: {artist.artistLanguage}");
            //        Console.WriteLine($"artist network: {artist.companyName}");


            //    }
            //}
        }
    }
}