using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("BANNER")]
public partial class Banner
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string? Image { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string? Title { get; set; }

    [Column("SUB_TITLE")]
    [StringLength(255)]
    public string? SubTitle { get; set; }

    [Column("URLS")]
    [StringLength(255)]
    public string? Urls { get; set; }

    [Column("ORDERS")]
    public int Orders { get; set; }

    [Column("TYPE")]
    [StringLength(500)]
    public string? Type { get; set; }

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

    [Column("NOTES")]
    public string? Notes { get; set; }

    [Column("STATUS")]
    public byte Status { get; set; }

    [Column("ISDELETE")]
    public bool Isdelete { get; set; }
}
