using System.ComponentModel.DataAnnotations;

namespace task01.Model
{
    public class School
    {
        public enum SchoolType
        {
            Public = 1,
            Experimental = 2,
            Private = 3,
            International = 4
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "يجب ادخال اسم المدرسه")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "يجب ان يكون الاسم لا يقل عن 3 احرف ولا يزيد عن 50 حرف")]
        public string Name { get; set; } = String.Empty;
        [Required]
        [StringLength(50,ErrorMessage ="يجب ان لا يقل عن 50 حرف ")]
        public string Address { get; set; }=String.Empty;
        [StringLength(11, MinimumLength = 11, ErrorMessage = "رقم الهاتف يجب أن يكون 11 رقم")]

        [Required(ErrorMessage = "نوع المدرسة مطلوب")]
        public SchoolType Type { get; set; }
        public ICollection<Student> Students=new List<Student>();
        public ICollection<Teacher> Teachers = new List<Teacher>();



    }
}
