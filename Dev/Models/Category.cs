using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("CATEGORY")]
public partial class Category
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(200)]
    public string? Title { get; set; }

    [Column("ICON")]
    [StringLength(200)]
    public string? Icon { get; set; }

    [Column("MATE_TITLE")]
    [StringLength(500)]
    public string? MateTitle { get; set; }

    [Column("META_KEYWORD")]
    [StringLength(500)]
    public string? MetaKeyword { get; set; }

    [Column("META_DESCRIPTION")]
    [StringLength(500)]
    public string? MetaDescription { get; set; }

    [Column("SLUG")]
    [StringLength(500)]
    public string? Slug { get; set; }

    [Column("ORDERS")]
    public int? Orders { get; set; }

    [Column("PARENTID")]
    public int? Parentid { get; set; }

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

    [Column("NOTES", TypeName = "ntext")]
    public string? Notes { get; set; }

    [Column("STATUS")]
    public byte? Status { get; set; }

    [Column("ISDELETE")]
    public bool? Isdelete { get; set; }
}
