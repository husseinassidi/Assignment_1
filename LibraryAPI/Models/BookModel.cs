namespace LibraryAPI.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int YearPublished { get; set; }


        public int AuthorId { get; set; }
        public AuthorModel? AuthorModel { get; set; }
    }
}