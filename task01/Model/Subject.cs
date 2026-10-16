using System.ComponentModel.DataAnnotations;

namespace task01.Model
{
    public class Subject
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="يجب ادخال اسم الماده")]
        [StringLength(30,ErrorMessage ="يجب ان لا يتجاوز اسم الماده 30 حرف")]
        public string Name { get; set; }=string.Empty;
        [Required(ErrorMessage = "يجب ادخال الدرجة الكبرى")]
        [Range(1, 100, ErrorMessage = "الدرجة الكبرى يجب أن تكون أكبر من الصفر")]
        public double MaxDegree { get; set; } 

        [Required(ErrorMessage = "يجب ادخال الدرجة الصغرى")]
        [Range(0, 100, ErrorMessage = "الدرجة الصغرى غير صحيحة")]
        public double MinDegree { get; set; }

    }
}
