using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("PRODUCT_MATERIALS")]
public partial class ProductMaterial
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PID")]
    public int? Pid { get; set; }

    [Column("MID")]
    public int? Mid { get; set; }
}
