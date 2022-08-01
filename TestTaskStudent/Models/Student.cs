using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskStudent.Models;

public class Student
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name="Student No")]
    public int StudentNo { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(150)")]
    [Display(Name = "Student Name")]
    public string Name { get; set; }
    
    [Required]
    [Column(TypeName = "int")]
    [Display(Name = "Section")]
    public int Section { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(150)")]
    [Display(Name = "Branch")]
    public string Branch { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(150)")]
    [Display(Name = "EmailId")]
    public string EmailId { get; set; }
    
}