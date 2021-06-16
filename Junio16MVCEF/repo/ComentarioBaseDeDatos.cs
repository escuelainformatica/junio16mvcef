using Junio16MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junio16MVCEF.repo
{

    // que hace las operacion relacionadas con la base de datos y los comentarios
    public class ComentarioBaseDeDatos
    {
        public static void Insertar(Comentario com)
        {
            using(var ctx=new Base9JunioContext())
            {
                ctx.Comentarios.Add(com); // insert into Comentario()...
                ctx.SaveChanges(); // se guarda todos los datos pendientes.
            }
        }
        public static List<Comentario> ListarTodo()
        {

            using(var ctx=new Base9JunioContext())
            {
                var listado=ctx.Comentarios.OrderByDescending( c => c.IdComentario).ToList();
                return listado;
            }
        }
    }
}
