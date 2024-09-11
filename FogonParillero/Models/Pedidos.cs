using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic; // Agregar esta directiva

namespace FogonParillero.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PedidoId")]
        public int PedidoId { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("MesaId")]
        public string MesaId { get; set; }

        [Required]
        [Column("FechaPedido")]
        public DateTime FechaPedido { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Estado")]
        public string Estado { get; set; }

        [Required]
        [Column("Total")]
        public decimal Total { get; set; }

        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }

        // Corregir la propiedad para representar la relación uno a muchos con PedidoDetalle
        public List<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
