using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_CALIFICACIONES
{
    class Calificacion : CollectionBase
    {      
        public void Add(object guardar) // ESTE METODO SE ASIGNA PARA AÑADIR A LA LISTA 
        {
            InnerList.Add(guardar);
        }
        public void Remove(object guardar) // ESTE METODO PARA REMOVER ELEMENTOS DE ELLA
        {
            InnerList.Remove(guardar);
        }
        public new void Clear() // LIMPIA LA LISTA 
        {
            InnerList.Clear();
            GC.Collect();
        }
        public new int Count() // CALCULA LA CANTIDAD DE ELEMENTOS DE LA LISTA
        {
            return InnerList.Count;
        }       
    }
}
