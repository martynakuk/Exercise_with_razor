namespace cw11.Data
{
    public interface IStudentService
    {
        public ICollection<Student> GetStudents();
        public Student? GetStudentById(int id);
        public void RemoveByID(int id);
    }

    public class StudentService : IStudentService
    {
        private const int V = 5;
        private ICollection<Student> _students;

        public StudentService()
        {



            _students = new List<Student>
            {
                new Student()
                {
                    Id = 1,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Maciek",
                    LastName = "Nowak",
                    Birthdate = new DateTime(2000,01,10),
                    Studies = "Biologia"
                },
                new Student()
                {
                    Id = 2,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Franek",
                    LastName = "Kowalski",
                    Birthdate = new DateTime(1999,06,15),
                    Studies = "Fizyka"
                },
                new Student()
                {
                    Id = 3,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Kasia",
                    LastName = "Wiśniewska",
                    Birthdate = new DateTime(1998,09,20),
                    Studies = "Matematyka"
                },
                new Student()
                {
                    Id = 4,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Bartek",
                    LastName = "Szczepański",
                    Birthdate = new DateTime(2001,11,30),
                    Studies = "Informatyka"
                },
                new Student()
                {
                    Id = 5,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Ania",
                    LastName = "Kowalczyk",
                    Birthdate = new DateTime(2000,05,25),
                    Studies = "Chemia"
                },
                new Student()
                {
                    Id = 6,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Wojtek",
                    LastName = "Szymański",
                    Birthdate = new DateTime(1999,03,10),
                    Studies = "Historia"
                },
                new Student()
                {
                    Id = 7,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Magda",
                    LastName = "Nowicka",
                    Birthdate = new DateTime(2002,04,05),
                    Studies = "Socjologia"
                },
                new Student()
                {
                    Id = 8,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Kamil",
                    LastName = "Wójcik",
                    Birthdate = new DateTime(1997,12,25),
                    Studies = "Psychologia"
                },
                new Student()
                {
                    Id = 9,
                    AvatarUrl = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png",
                    FirstName = "Jacek",
                    LastName = "Maruda",
                    Birthdate = new DateTime(1997,12,12),
                    Studies = "Informatyka"
                }
            };


        }


        public Student? GetStudentById(int id)
        {
            return _students.FirstOrDefault(e => e.Id == id);
        }

        public ICollection<Student> GetStudents()
        {
            return _students;
        }

        public void RemoveByID(int id)
        {
            var studentToRemove = _students.FirstOrDefault(e => e.Id == id);
            if (studentToRemove != null)
            {
                _students.Remove(studentToRemove);
            }
        }
    }

}
