using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Clase
    {
        public int Id;
        public string Nombre;
        public string Descripción;

        public Clase ( int id, string nombre, string descripción)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripción = descripción;

        }
    }
}
