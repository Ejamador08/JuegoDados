using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_DADOS
{
    class Dado
    {
        private int Numero;
        Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        public Dado()
        {
        }
        public int Tirar() {
            int numero;
            
            numero = random.Next(1, 6);
            return numero;
        }
        public int ObtenerNumero() {
            return this.Numero;
        }
        public void establecerNumero(int numero) {
            this.Numero = numero;
        }       
    }
}
