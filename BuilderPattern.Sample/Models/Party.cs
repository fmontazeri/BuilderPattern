namespace BuilderPattern.Sample.Models;

public class Party
{
    public Party(long id , string name)
    {
        this.Id = id;
        this.Name = name;

    }
    public long Id { get; set; }
    public string Name { get; set; }
}