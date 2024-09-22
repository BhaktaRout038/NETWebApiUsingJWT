namespace ConsumeJWTTokenFromWebAPI.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public bool IsAlloted { get; set; }
    }
}
