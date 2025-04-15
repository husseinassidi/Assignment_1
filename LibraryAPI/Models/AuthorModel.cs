namespace LibraryAPI.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public List<BookModel> Books { get; set; } = new();
        
    }
}