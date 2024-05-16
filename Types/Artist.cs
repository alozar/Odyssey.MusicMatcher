namespace Odyssey.MusicMatcher;

public class Artist
{
    public Artist(string id, string name)
    {
        Id = id;
        Name = name;
    }
    
    [ID]
    public string Id { get; set; }

    public string Name { get; set; }

    public int? Followers { get; set; }

    public float? Popularity { get; set; }
}
