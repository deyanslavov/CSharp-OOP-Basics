using System;

public class Song
{
    private string artist;
    private string name;
    private TimeSpan length;

    public Song()
    {

    }

    public string Artist
    {
        get { return artist; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException(3, 20);
            }
            artist = value;
        }
    }
    
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException(3, 30);
            }
            name = value;
        }
    }
        
    public TimeSpan Length
    {
        get { return length; }
        set
        {
            if (value.Seconds < 0 || value.Seconds > 899)
            {
                throw new InvalidSongLengthException();
            }
            length = value;
        }
    }

}

