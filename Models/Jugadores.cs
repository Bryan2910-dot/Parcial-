using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_.Models
{
    [Table("t_jugadores")]
    public class Jugadores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Posicion { get; set; }
        public string? Edad { get; set; }
        public string? EquipoActual { get; set; }
    }
}