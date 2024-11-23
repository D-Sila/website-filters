public class Filter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; } // Air Filter or Oil Filter
    public string Compatibility { get; set; }
    public decimal Price { get; set; }
    public bool InStock { get; set; }
}
