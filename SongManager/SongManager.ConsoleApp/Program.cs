using System;

namespace SongManager.ConsoleApp
{
    class Program
    {
        struct Song
        {
            public string Title;
            public string Artist;
        }
        static void Main(string[] args)
        {
            int cnt = 0;
            Song[] songs = new Song[10];
            
            string title;
            string artist;
            do
            {
                Console.WriteLine("\nSong Nr."+(cnt+1));
                Console.Write("Titel:");
                title = Console.ReadLine();
                if (title != "")
                {
                    Console.Write("Artist:");
                    artist = Console.ReadLine();
                    songs[cnt].Title = title;
                    songs[cnt].Artist = artist;
                    cnt++;
                }

            } while (title != "" && cnt < 10);

            OrderSongs(songs,cnt);

            PrintSongs(songs,cnt);
            Console.ReadLine();
        }

        private static void PrintSongs(Song[] songs,int cnt)
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine($"{songs[i].Title,-20} {songs[i].Artist,-20}");
            }
        }

        private static void OrderSongs(Song[] songs, int cnt)
        {
            int j;
            Song actSong;
            for (int i = 1; i < cnt; i++)
            {
                j = i;
                actSong = songs[j];
                while (j > 0 && songs[j - 1].Title.CompareTo(actSong.Title) > 0)
                {
                    songs[j] = songs[j - 1];
                    j--;
                }
                songs[j] = actSong;
            }
        }
    }
}
