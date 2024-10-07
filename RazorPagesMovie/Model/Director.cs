namespace RazorPagesMovie.Model
{
    public class Director
    {
        public int Id {  get; set; }
        public string FistName { get; set; } = string.Empty;
        public string LastName {  get; set; } = string.Empty;
        public DateTime Birthday {  get; set; }
        public HashSet<Movie> MoviesList { get; set; } = new HashSet<Movie>();
    }
}
