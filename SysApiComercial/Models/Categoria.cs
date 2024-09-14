using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace SysApiComercial.Models;

[Table("CATEGORIA")]
public partial class Categoria
{

    public Categoria()
    {
        Producto = new HashSet<Producto>();
    }
    [Key]
    public int IdCategoria { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("oCategoria")]

    [JsonIgnore]
    public virtual ICollection<Producto> Producto { get; } = new List<Producto>();

}
