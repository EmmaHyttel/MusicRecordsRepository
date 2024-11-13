namespace MusicRecordsRepository.Models;

public class MusicRecords
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public int PublicationYear { get; set; }
    public string Genre { get; set; }

    public MusicRecords(string title, string artist, int duration, int publicationYear, string genre)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        PublicationYear = publicationYear;
        Genre = genre;
    }

    public MusicRecords()
    {
    }

    public override string ToString()
    {
        return $"{{{nameof(Title)}={Title}, {nameof(Artist)}={Artist}, {nameof(Duration)}={Duration.ToString()}, {nameof(PublicationYear)}={PublicationYear.ToString()}, {nameof(Genre)}={Genre}}}";
    }
}
