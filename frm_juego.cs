using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUEGO_DADOS
{
    public partial class frm_juego : Form
    {
        private int numeroIntento;
        private Dado obj_dado;
        private List<Jugador> jugadores;
        private int turnoDe = 0;
        private int tiradaActual = 0;//<------------------------
        public frm_juego()
        {
            InitializeComponent();
            inicializaciones();
        }
        public void inicializaciones()
        {
            obj_dado = new Dado();
            jugadores = new List<Jugador>();
            numeroIntento = 2;
            turnoDe = 0;//<-------------
            tiradaActual = 0;//<---------------
        }
        public void registarJugadores()
        {
            //Declaramos una variable para preguntar el numero de jugadores
            int NumeroJugadores;

            try
            {
                //Entrada de datos mediante un inputbox
                NumeroJugadores = int.Parse(
                    Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de Jugadores",
                    "Empezar Juego", "2", 100, 0));
                if (NumeroJugadores < 2 || NumeroJugadores > 5)
                {
                    MessageBox.Show("Solo puede ingresar mayor o igual a 2 y menor o igual a 5");
                }
                else
                {
                    // numero de veces que se preguntara el nombre, segun la variable numeroJugador
                    for (int indice = 0; indice < NumeroJugadores; indice++)
                    {
                        string nombreJugador = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el nombre del jugador " + (indice + 1),
                       "Registro", "", 100, 0);
                        Jugador jugador = new Jugador();
                        jugador.EstablecerNombre(nombreJugador);
                        jugador.establecerPuntos(0);
                        jugadores.Add(jugador);

                    }
                    dv_jugadores.DataSource = jugadores;

                }

                numeroIntento = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cuantos lanzamiento hara cada jugador",
                    "Registro", "", 100, 0));
                numeroIntento *= 2*jugadores.Count;


            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dv_jugadores.DataSource = jugadores.ToList();
        }
        public void tirarDado(Jugador tirando)
        {
            int resultadoDado1 = obj_dado.Tirar();
            int resultadoDado2 = obj_dado.Tirar();
            dado1.Image = seleccionarImagen(resultadoDado1);
            dado2.Image = seleccionarImagen(resultadoDado2);
            lbl_resultado.Text = "Ha sacado " + resultadoDado1 + " Y " + resultadoDado2 + "="
                + (resultadoDado1 + resultadoDado2);


            int sumaDados = resultadoDado1 + resultadoDado2;
            jugadores[turnoDe].PuntajeJugador += sumaDados;
            dv_jugadores.DataSource = jugadores.ToList();
            turnoDe += 1;
            if (turnoDe > jugadores.Count - 1) turnoDe = 0;
            btn_tirar.Text = "Turno de tirar de " + jugadores[turnoDe].obtenerNombre();
        }
        public Image seleccionarImagen(int Cara)
        {
            switch (Cara)
            {
                case 1:
                    return Properties.Resources.cara01;
                case 2:
                    return Properties.Resources.cara02;
                case 3:
                    return Properties.Resources.cara03;
                case 4:
                    return Properties.Resources.cara04;
                case 5:
                    return Properties.Resources.cara05;
                case 6:
                    return Properties.Resources.cara06;
                default:
                    return Properties.Resources.cara01;
            }
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            registarJugadores();
            turnoDe = 0;
            btn_tirar.Text = "Turno de tirar de " + jugadores[0].obtenerNombre();
        }

        private void btn_tirar_Click(object sender, EventArgs e)
        {
            if (jugadores.Count > 0)
            {
                tiradaActual += 1;
                if (tiradaActual <= numeroIntento)
                {
                    tiempoAnimacion.Start();
                    pararAnimacion.Start();
                }
                else {
                    string nombreGanador= jugadores.OrderByDescending(t => t.PuntajeJugador).First().Nombrejugador;
                    int puntaje =jugadores.OrderByDescending(t => t.PuntajeJugador).First().PuntajeJugador;



                    MessageBox.Show("El ganador del juego es "+nombreGanador+" Con un puntaje de "+puntaje+"" +
                        " felicidades a nuestro ganador    Siiiiuuuu",
                    "GANADOR!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No hay Jugadores, haga Click en el boton iniciar",
                    "Sin Jugadores", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tiempoAnimacion_Tick(object sender, EventArgs e)
        {
            dado1.Image = seleccionarImagen(obj_dado.Tirar());
            dado2.Image = seleccionarImagen(obj_dado.Tirar());
        }

        private void pararAnimacion_Tick(object sender, EventArgs e)
        {
            tiempoAnimacion.Stop();
            pararAnimacion.Stop();
            tirarDado(null);
        }

        private void frm_juego_Load(object sender, EventArgs e)
        {

        }
    }
}
