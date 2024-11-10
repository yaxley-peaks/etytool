using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EtyTool.Entities;

/// <summary>
/// Languages
/// </summary>
[Table("langs")]
[Microsoft.EntityFrameworkCore.Index("Code", Name = "langs_code_uniq", IsUnique = true)]
public partial class Lang
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// ISO 639 SET 1, 2 letter codes
    /// </summary>
    [Column("code")]
    [StringLength(2)]
    public string Code { get; set; } = null!;

    [InverseProperty("LangNavigation")]
    public virtual ICollection<Word> Words { get; set; } = new List<Word>();
}
