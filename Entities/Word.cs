using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EtyTool.Entities;

/// <summary>
/// associate word with etymology
/// </summary>
[Table("words")]
[Microsoft.EntityFrameworkCore.Index("Word1", Name = "word_uniq", IsUnique = true)]
public partial class Word
{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }

    /// <summary>
    /// word
    /// </summary>
    [Column("word")]
    [StringLength(100)]
    public string Word1 { get; set; } = null!;

    /// <summary>
    /// fk from langs, language the word is in
    /// </summary>
    [Column("lang")]
    public int Lang { get; set; }

    /// <summary>
    /// Lang whence a word comes from
    /// </summary>
    [Column("etymology")]
    public int Etymology { get; set; }

    [ForeignKey("Etymology")]
    [InverseProperty("Words")]
    public virtual Etymology EtymologyNavigation { get; set; } = null!;

    [ForeignKey("Lang")]
    [InverseProperty("Words")]
    public virtual Lang LangNavigation { get; set; } = null!;
}