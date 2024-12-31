using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("PRODUCT_IMAGES")]
public partial class ProductImage
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PID")]
    public int? Pid { get; set; }

    [Column("IMAGE")]
    [StringLength(500)]
    public string? Image { get; set; }
}
