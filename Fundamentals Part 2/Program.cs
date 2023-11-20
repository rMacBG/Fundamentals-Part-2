using System.Numerics;

namespace Fundamentals_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RandomizeWords();
            //BigFactorial();
            Songs();

        }
         private static void RandomizeWords()
        {
            string[] words = Console.ReadLine()
                 .Split()
                 .ToArray();

            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(words.Length);

                string currentWord = words[i];
                string randomWord = words[randomIndex];
                words[i] = randomWord;
                words[randomIndex] = currentWord;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        private static void BigFactorial()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = n; i >= 2; i--)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }

        private static void Songs()
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('_').ToArray();
                string listType = tokens[0];
                string songName = tokens[1];
                string songTime = tokens[2];
                //Song song = new Song
                //{
                //    Name = songName,
                //    TypeList = listType,
                //    Time = songTime
                //};
                Song song = new Song(listType, songName, songTime);
                playlist.Add(song);
            }
            string filter = Console.ReadLine();

            if (filter != "all")
            {
                for (int i = playlist.Count - 1; i >= 0; i--)
                {
                    Song currentSong = playlist[i];
                    if (currentSong.TypeList == filter)
                    {

                    }
                    else
                    {
                        playlist.RemoveAt(i);
                    }
                }
            }

            foreach (Song song in playlist)
            {
                Console.WriteLine(song.Name);
            }


        }
    }

    public class Song
    {
        public Song()
        {
            
        }
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string  Name { get; set; }
        public string Time { get; set; }
    }
}