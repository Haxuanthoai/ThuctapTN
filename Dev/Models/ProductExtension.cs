using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("PRODUCT_EXTENSIONS")]
public partial class ProductExtension
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PID")]
    public int? Pid { get; set; }

    [Column("EID")]
    public int? Eid { get; set; }

    [Column("CONTENT", TypeName = "ntext")]
    public string? Content { get; set; }
}
