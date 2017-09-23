using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Personaje
    {
        public int Id;
        public string Nombre;
        public int Nivel;
        public int Fuerza;
        public int Destreza;
        public int Constitución;
        public int Inteligencia;
        public int Sabiduría;
        public int Carisma;

        public Personaje (int id, string nombre, int nivel, int fuerza, int destreza, 
            int constitución, int inteligencia, int sabiduría, int carisma)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Fuerza = fuerza;
            this.Destreza = destreza;
            this.Constitución = constitución;
            this.Inteligencia = inteligencia;
            this.Sabiduría = sabiduría;
            this.Carisma = carisma;

        }
              
        

       public void HAblarpersonaje()
        {
            Console.WriteLine("me llamo fuefueufuefueufue");
        }
        

    }
}
