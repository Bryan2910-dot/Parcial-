using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_.Models
{
    [Table("t_asignamiento")]
    public class Asignamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EquipoId { get; set; } // Clave foránea para Equipo

        [ForeignKey("EquipoId")]
        public Equipos? Equipo { get; set; }

        [Required]
        public int JugadorId { get; set; } // Clave foránea para Jugador

        [ForeignKey("JugadorId")]
        public Jugadores? Jugador { get; set; }

        
    }
}