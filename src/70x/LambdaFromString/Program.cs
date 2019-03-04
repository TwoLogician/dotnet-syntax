using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Scripting;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;

public class Album {
    public int Quantity { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
}

class Program {
    static async Task Main(string[] args) {

        Test.Size();

        var albums = new List<Album> {
                new Album { Quantity = 10, Artist = "Betontod", Title = "Revolution" },
                new Album { Quantity = 50, Artist = "The Dangerous Summer", Title = "The Dangerous Summer" },
                new Album { Quantity = 200, Artist = "Depeche Mode", Title = "Spirit" },
            };

        var discountFilter = "album => album.Quantity > 20";
        var options = ScriptOptions.Default.AddReferences(typeof(Album).Assembly);

        Func<Album, bool> discountFilterExpression = await CSharpScript.EvaluateAsync<Func<Album, bool>>(discountFilter, options);

        var discountedAlbums = albums.Where(discountFilterExpression).ToList();
        Console.WriteLine(discountedAlbums.Count());
    }
}