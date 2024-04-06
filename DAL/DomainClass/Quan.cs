using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("QUAN")]
public partial class Quan
{
    [Key]
    [Column("MAQUAN")]
    [StringLength(7)]
    public string Maquan { get; set; } = null!;

    [Column("TENQUAN")]
    [StringLength(50)]
    public string Tenquan { get; set; } = null!;

    [InverseProperty("MaquanNavigation")]
    public virtual ICollection<Thanhpho> Thanhphos { get; set; } = new List<Thanhpho>();
}
