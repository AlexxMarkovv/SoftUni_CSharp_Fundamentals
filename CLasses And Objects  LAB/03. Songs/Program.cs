using System;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            List<Song> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }

        class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
            
        } 
    }
}