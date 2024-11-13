namespace MusicRecordsRepository.Models;

public class MusicRecords
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public int PublicationYear { get; set; }
    public string Genre { get; set; }

    public MusicRecords(int id, string title, string artist, int duration, int publicationYear, string genre)
    {
        Id = id;
        Title = title;
        Artist = artist;
        Duration = duration;
        PublicationYear = publicationYear;
        Genre = genre;
    }

    public MusicRecords()
    {
    }

    public void ValidateTitle()
    {
        if (Title == null)
        {
            throw new ArgumentNullException("Title is null");
        }

        if (Title.Length < 1)
        {
            throw new ArgumentException("Title must be at least 1 character: " + Title);
        }
    }

    public void ValidateArtist()
    {
        if (Artist == null)
        {
            throw new ArgumentNullException("Artist is null");
        }

        if (Title.Length < 1)
        {
            throw new ArgumentException("Artist must be at least 1 character: " + Artist);
        }
    }

    public void ValidateDuration()
    {
        if (Duration < 30 || Duration > 4800)
        {
            throw new ArgumentOutOfRangeException("Duration must be minimum 30 seconds and maximum 4800 seconds: " + Duration);
        }
    }

    public void ValidatePublicationYear()
    {
        if (PublicationYear < 1982)
            throw new ArgumentOutOfRangeException("Publication year must be 1982 or after: " + PublicationYear);
    }

    public void ValidateGenre()
    {
        if (Genre == null)
        {
            throw new ArgumentNullException("Genre is null");
        }

        if (Genre.Length < 3)
        {
            throw new ArgumentException("Genre must be at least 3 character: " + Genre);
        }
    }

    public void Validate()
    {
        ValidateTitle();
        ValidateArtist();
        ValidateDuration();
        ValidatePublicationYear();
        ValidateGenre();
    }

    // Hvad er Equals() --> hvordan implementeres det og hvorfor --> override 
    // Implementer også GetHashCode() --> Hvad er det og hvorfor implementeres det --> override 
    // fx 
    public override bool Equals(object? obj)
    {
        return obj is MusicRecords record &&
            Id == record.Id &&
            Title == record.Title &&
            Artist == record.Artist &&
            Duration == record.Duration &&
            PublicationYear == record.PublicationYear &&
            Genre == record.Genre;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Title, Artist, Duration, PublicationYear, Genre);
    }

    public override string ToString()
    {
        return $"{Id}, {Title}, {Artist}, {Duration}, {PublicationYear}, {Genre}";
    }
}
