using System;
using System.Reflection;
namespace FunWithMusic
{

    class Program
    {
        enum Genre
        {
            HardRock,
            Metal,
            Alternative,
            Blues,
            HipHop
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;


            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;

            }

            public void setTitle(string title)
            {
                Title=title;
            }

            public void setArtist(string artist)
            {
               Artist=artist;
            }

            public void setAlbum(string album)
            {
                Album=album;
            }

            public void setLength(string length)
            {
                Length=length;
            }

            public void setGenre(Genre genre)
            {
                Genre=genre;
            }

            public string Display()
            {
                return "Title " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the Artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the Album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("H - hardRock\nM - metal\nA - alternative\nB - blues\nP - hiphop ");
            Genre tempGenre = Genre.HardRock;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'H':
                    tempGenre = Genre.HardRock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'A':
                    tempGenre = Genre.Alternative;
                    break;
                case 'B':
                    tempGenre = Genre.Blues;
                    break;
                case 'P':
                    tempGenre = Genre.HipHop;
                    break;

            }


            // Creating the first movie structure variable
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            // Copying the structure variable
            Music newMusic = music;
            //changing values in the new structure variable
            newMusic.setAlbum("Ten");
            newMusic.setTitle("Evenflow");
            newMusic.setArtist("Pearl Jam");
            // Printing the new music
            Console.WriteLine("Here's music #2");
            Console.WriteLine($"{newMusic.Display()}");
            Console.WriteLine();
            //Printing the original
            Console.WriteLine("Here's music #1");
            Console.WriteLine($"{music.Display()}");
            


        }
    }
}
    
