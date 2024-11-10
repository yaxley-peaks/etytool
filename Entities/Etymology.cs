using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EtyTool.Entities;

/// <summary>
/// List of langs seen before
/// </summary>
[Table("etymology")]
[Microsoft.EntityFrameworkCore.Index("Name", Name = "etymology_name_uniq", IsUnique = true)]
public partial class Etymology
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(300)]
    public string Name { get; set; } = null!;

    [InverseProperty("EtymologyNavigation")]
    public virtual ICollection<Word> Words { get; set; } = new List<Word>();
}
