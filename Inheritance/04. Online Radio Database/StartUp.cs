namespace _04._Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var songs = new List<Song>();
            int numberOfSongs = int.Parse(Console.ReadLine());
            
            GetSongs(numberOfSongs, songs);

            Console.WriteLine($"Songs added: {songs.Count}");

            var seconds = ((songs.Sum(a => a.Length.Hours) * 3600) + (songs.Sum(a => a.Length.Minutes) * 60) + songs.Sum(a => a.Length.Seconds)) % 60;
            var minutes = (((songs.Sum(a => a.Length.Hours) * 3600) + (songs.Sum(a => a.Length.Minutes) * 60) + songs.Sum(a => a.Length.Seconds)) / 60) % 60;
            var hours = ((songs.Sum(a => a.Length.Hours) * 3600) + (songs.Sum(a => a.Length.Minutes) * 60) + songs.Sum(a => a.Length.Seconds)) / 3600;

            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }

        private static void GetSongs(int numberOfSongs, List<Song> songs)
        {

            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                    var song = new Song();

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (j == 0)
                        {
                            song.Artist = input[j];
                        }
                        else if (j == 1)
                        {
                            song.Name = input[j];
                        }
                        else if (j == 2)
                        {
                            var timeTokens = input[j].Split(':');
                            ValidateMinutes(int.Parse(timeTokens[0]));
                            ValidateSeconds(int.Parse(timeTokens[1]));
                            song.Length = TimeSpan.Parse("00:" + input[j]);
                        }
                    }
                    ValidateSong(song);
                    songs.Add(song);
                    Console.WriteLine("Song added.");

                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }
        }

        private static void ValidateSong(Song song)
        {
            if (song.Length == null || song.Artist == null || song.Name == null)
            {
                throw new InvalidSongException();
            }
        }

        private static void ValidateMinutes(int minutes)
        {
            if (minutes < 0 || minutes > 14)
            {
                throw new InvalidSongMinutesException(0, 14);
            }
        }

        private static void ValidateSeconds(int seconds)
        {
            if (seconds < 0 || seconds > 59)
            {
                throw new InvalidSongSecondsException(0, 59);
            }
        }
    }
}
