using CW14.Database;
using System.ComponentModel.DataAnnotations;
namespace CW14.Models;

public class Book
{
    [Display(Name = "شناسه کتاب")]
    public int Id { get; set; }

    [Required(ErrorMessage ="اجباری")]
    [MaxLength(20, ErrorMessage = "تعداد حروف برند نباید بیشتر از 10 باشد")]
    [MinLength(5, ErrorMessage = "تعداد حروف برند نباید کمتر از 5 باشد")]
    [Display(Name = "عنوان کتاب")]
    public string Title { get; set; }

    [Required(ErrorMessage = "اجباری")]
    [Display(Name ="خریدار")]
    public string OwenrName { get; set; }

    [Display(Name = "نویسنده")]
    [Required(ErrorMessage = "اجباری")]
    public string Writer { get; set; }

    [Required(ErrorMessage = "اجباری")]
    [Display(Name = "تاریخ اضافه شدن کتاب به کتابخانه")]
    [DataType(DataType.DateTime)]
    public DateTime AddDate { get; set; }
}
