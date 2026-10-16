using System.ComponentModel.DataAnnotations;

namespace task01.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public int Salary { get; set; }
        [EmailAddress(ErrorMessage ="الرجاء ادخال بريد الكتروني صحيح")]
        public string Email { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
