namespace PracticeExam.WebApp.Models;

public class Wine
{
    public int Id { get; set; }
    public string Name          { get; set; }
    public string Description   { get; set; }
    public string Country       { get; set; }
    public string Region        { get; set; }
    public decimal Price        { get; set; }
    public int Year             { get; set; }
}
