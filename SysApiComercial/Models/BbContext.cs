using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SysApiComercial.Models;

public partial class BbContext : DbContext
{
    public BbContext()
    {
    }

    public BbContext(DbContextOptions<BbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK_CATEGORI_A3C02A10DA8BD2A5");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK_PRODUCTO_09889210B70FB937");

            entity.HasOne(d => d.oCategoria).WithMany(p => p.Producto).HasConstraintName("FK_IDCATEGORIA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
