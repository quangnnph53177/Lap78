using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("THANHPHO")]
public partial class Thanhpho
{
    [Column("STT")]
    public int Stt { get; set; }

    public Guid? Guidid { get; set; }

    [Key]
    [Column("MATP")]
    [StringLength(7)]
    public string Matp { get; set; } = null!;

    [Column("TENTP")]
    [StringLength(50)]
    public string Tentp { get; set; } = null!;

    [Column("MAQUAN")]
    [StringLength(7)]
    public string Maquan { get; set; } = null!;

    [ForeignKey("Maquan")]
    [InverseProperty("Thanhphos")]
    public virtual Quan MaquanNavigation { get; set; } = null!;
}
