using System.ComponentModel.DataAnnotations;

namespace task01.Model
{
    public class Student
    { 
        [Key]
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage = "اسم الطالب لا يتجاوز ال 50 حرف ")]
        [Required(ErrorMessage ="يجب ادخال اسم الطالب ")]
        public string? Name { get; set; }

        public int Age { get; set; }
        [StringLength(11,MinimumLength =11,ErrorMessage ="يجب ان يكون رقم الهاتف لا يقل عن 11 رقم و ان لا يزيد عن 11 رقم")]
        public string? Phone { get; set; }
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
