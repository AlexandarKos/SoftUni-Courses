using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsNumber = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsNumber; i++)
            {
                List<string> input = Console.ReadLine().Split("_").ToList();

                Song song = new Song (input[0], input[1], input[2] );

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.Where(s => s.TypeList == command).ToList();
                foreach (var song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }

        }
    }
    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}