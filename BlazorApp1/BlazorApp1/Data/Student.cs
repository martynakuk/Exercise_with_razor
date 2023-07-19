namespace cw11.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string AvatarUrl { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public string Studies { get; set; } = null!;
    }
}
