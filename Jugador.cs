using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_DADOS
{
    public class Jugador
    {
        private String nombrejugador;//cambiar el nombre es Ctrl+ R, R
        private int puntajeJugador;

        public string Nombrejugador
        {
            get => nombrejugador;
            set => nombrejugador = value;
        }
        public int PuntajeJugador
        {
            get => puntajeJugador;
            set => puntajeJugador = value;
        }

        public Jugador(string nombre, int puntaje)
        {
            Nombrejugador = nombre;
            PuntajeJugador = puntaje;
        }

        public Jugador()
        {
        }
        public void EstablecerNombre(String Nombre)
        {
            //la palabra reservada This, se usa para referenciar a todo contenido en la clase
            // en este caso la variable nombre
            // aqui asignamos el valor del parametro nombre a la variable nombre de la clase
            this.Nombrejugador = Nombre;
        }
        public String obtenerNombre()
        {
            /*
             * la palabra Return se usa para devolver un valor en este caso hemos 
             * especificado un valor de tipo String
             * esta funcion o metodo, lo unico que hace es devolver el valor de la variable Nombre
             */
            return this.Nombrejugador;
        }
        public void establecerPuntos(int Puntos)
        {
            //asignamos el valor de puntos a la variable puntaje de la clase
            this.PuntajeJugador = Puntos;
        }
        public int obtenerPuntaje()
        {
            // devolvemos el valor de la variable de la clase puntaje con este metodo
            return this.PuntajeJugador;
        }

    }
}
