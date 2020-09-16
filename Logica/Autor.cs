using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        // metodos
        // recibir de Presentacion 
        // y si necesita envia a Datos
        public void Agregar(List<Entidades.Autor> lista,
                            Entidades.Autor autor )
        {
            // agregar un elemento a una coleccion
            autor.ID = lista.Count + 1;
            lista.Add(autor);
        }
        public List<Entidades.Autor> TraerTodos(List<Entidades.Autor> lista)
        {
            return lista;
        }
        public void Modificar()
        { }
        public void Borrar()
        { }

    }
}
