﻿using EtyTool.Entities;
using Microsoft.EntityFrameworkCore;

namespace EtyTool.Context;

public partial class EtyToolContext : DbContext
{
    public EtyToolContext()
    {
    }

    public EtyToolContext(DbContextOptions<EtyToolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Etymology> Etymologies { get; set; }

    public virtual DbSet<Lang> Langs { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSeeding((context, _) =>
            {
                var lang = context.Set<Lang>().FirstOrDefault();
                if (lang != null) return;
                context.Set<Lang>().Add(new Lang()
                    {
                        Code = "en",
                        Name = "English"
                    }
                );
                context.SaveChanges();
            }
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Etymology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("etymology_pk");

            entity.ToTable("etymology", tb => tb.HasComment("List of langs seen before"));
        });

        modelBuilder.Entity<Lang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("langs_pk");

            entity.ToTable("langs", tb => tb.HasComment("Languages"));

            entity.Property(e => e.Code).HasComment("ISO 639 SET 1, 2 letter codes");
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("word__pk");

            entity.ToTable("words", tb => tb.HasComment("associate word with etymology"));

            entity.Property(e => e.Id)
                .HasComment("PK")
                .UseIdentityAlwaysColumn();
            entity.Property(e => e.Etymology).HasComment("Lang whence a word comes from");
            entity.Property(e => e.Lang).HasComment("fk from langs, language the word is in");
            entity.Property(e => e.Word1).HasComment("word");

            entity.HasOne(d => d.EtymologyNavigation).WithMany(p => p.Words)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("words_etymology_id_fk");

            entity.HasOne(d => d.LangNavigation).WithMany(p => p.Words)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("words_langs_id_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}