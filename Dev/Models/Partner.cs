using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("PARTNER")]
public partial class Partner
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string? Title { get; set; }

    [Column("LOGO")]
    [StringLength(255)]
    public string? Logo { get; set; }

    [Column("URL")]
    [StringLength(255)]
    public string? Url { get; set; }

    [Column("ORDERS")]
    public byte? Orders { get; set; }

    [Column("CREATED_DATE", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_DATE", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("ADMIN_CREATED")]
    [StringLength(255)]
    public string? AdminCreated { get; set; }

    [Column("ADMIN_UPDATED")]
    [StringLength(255)]
    public string? AdminUpdated { get; set; }

    [Column("CONTENT")]
    public string? Content { get; set; }

    [Column("STATUS")]
    public byte? Status { get; set; }

    [Column("ISDELETE")]
    public bool? Isdelete { get; set; }
}
