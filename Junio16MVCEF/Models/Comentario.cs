using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Junio16MVCEF.Models
{
    // [Table(name:"Comentarios")]
    public partial class Comentario
    {
        [Key]
        public int IdComentario { get; set; }


        [StringLength(50)]
        [Unicode(false)]
        public string Titulo { get; set; }

        [StringLength(500)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Nombre { get; set; }
    }
}
