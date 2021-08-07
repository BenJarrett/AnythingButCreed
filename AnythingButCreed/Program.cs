using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            { 
            new Song("Creed", "Higher"),
            new Song("Creed", "One Last Breath"),
            new Song("Creed", "With Arms Wide Open"),
            new Song("Creed", "My Sacrifice"),
            new Song("Creed", "What's This Life For"),
            new Song("Creed", "What If"),
            new Song("Counterparts", "The Constant"),
            new Song("Phoebe Bridgers", "Scott Street"),
            new Song("All Get Out", "The Season"),
            new Song("Samia", "Big Wheel"),
            new Song("Samia", "As You Are"),
            new Song("All Get Out", "My Friends"),
            };

            goodSongs.AddRange(allSongs.Where(song => song.Artist != "Creed"));

            foreach (var song in goodSongs)
            {

                Console.WriteLine($"{song.Artist}:" +
                    $"'{song.Name}'");
            }
        }
    }
}
