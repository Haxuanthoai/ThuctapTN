using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("INTRODUCTIONS")]
public partial class Introduction
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(300)]
    public string Title { get; set; } = null!;

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; } = null!;

    [Column("ORDERS")]
    public int? Orders { get; set; }

    [Column("DESCRIPTION")]
    public string? Description { get; set; }

    [Column("HOME")]
    public byte? Home { get; set; }

    [Column("TYPE")]
    public byte? Type { get; set; }

    [Column("PARENTID")]
    public int? Parentid { get; set; }

    [Column("META_TITLE")]
    [StringLength(500)]
    public string? MetaTitle { get; set; }

    [Column("META_KEYWORD")]
    [StringLength(500)]
    public string? MetaKeyword { get; set; }

    [Column("META_DESCRIPTION")]
    [StringLength(4000)]
    public string? MetaDescription { get; set; }

    [Column("SLUG")]
    [StringLength(500)]
    public string? Slug { get; set; }

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
    public byte Status { get; set; }

    [Column("ISDELETE")]
    public bool Isdelete { get; set; }
}
