using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev.Models;

[Table("CONTACT")]
public partial class Contact
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string? Title { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    public string? Email { get; set; }

    [Column("PHONE")]
    [StringLength(255)]
    public string? Phone { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string? Address { get; set; }

    [Column("CONTENT", TypeName = "ntext")]
    public string? Content { get; set; }

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

    [Column("STATUS")]
    public byte? Status { get; set; }

    [Column("ISDELETE")]
    public bool? Isdelete { get; set; }
}
