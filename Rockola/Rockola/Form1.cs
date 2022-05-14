using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rockola
{
    public partial class Form1 : Form
    {
        private int indice;
        private string[] mensaje;
        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
           indice++;
           if (indice > 3)
               indice = 0;
           label1.ImageIndex = indice;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CCanciones miCancion = new CCanciones();
            miCancion.ObtenerCanciones(indice);

            mensaje = miCancion.ObtenerCanciones(indice);
            listCanciones.Items.Clear();
            for (int i = 0; i < mensaje.Length; i++)
            {
                listCanciones.Items.Add(mensaje[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            indice = indice - 1;
            if (indice > -1)
            {
                label1.ImageIndex = indice;
            }
            else
            {
                indice = 3;
                label1.ImageIndex = indice;
            }
        }

        private void listCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ruta = "";
          
            for (int a = 0; a < mensaje.Length; a++)
            {
                if (indice == 0)
                {
                    if (listCanciones.Items[a].Selected == true)
                    {
                        ruta = rutaCancionesCarlos[a];
                    }
                }

                if (indice == 1)
                {
                    if (listCanciones.Items[a].Selected == true)
                    {
                        ruta = rutaCancionesJBalvin[a];
                    }
                }

                if (indice == 2)
                {
                    if (listCanciones.Items[a].Selected == true)
                    {
                        ruta = rutaCancionesJesseJoy[a];
                    }
                }

                if (indice == 3)
                {
                    if (listCanciones.Items[a].Selected == true)
                    {
                        ruta = rutaCancionesMana[a];
                    }
                }

            }
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        Dictionary<int, string> rutaCancionesCarlos = new Dictionary<int,  string>()
        {
             {0, @"C:\Rockola\Rockola\MUSICA\CarlosVives\Carlos Vives - Bailar Contigo.mp3"},
             {1, @"C:\Rockola\Rockola\MUSICA\CarlosVives\Carlos Vives - Como Le Gusta A Tu Cuerpo ft. Michel Teló.mp3"},
             {2, @"C:\Rockola\Rockola\MUSICA\CarlosVives\Carlos Vives - Cuando Nos Volvamos a Encontrar ft. Marc Anthony.mp3"},
             {3, @"C:\Rockola\Rockola\MUSICA\CarlosVives\Carlos Vives - Volví a Nacer.mp3"}
        };

        Dictionary<int, string> rutaCancionesJBalvin = new Dictionary<int, string>()
        {
             {0, @"C:\Rockola\Rockola\MUSICA\JBalvin\J Balvin - 6 AM ft. Farruko.mp3"},
             {1, @"C:\Rockola\Rockola\MUSICA\JBalvin\Thalía - Desde Esa Noche (Official Video) ft. Maluma.mp3"},
             {2, @"C:\Rockola\Rockola\MUSICA\JBalvin\Wisin, Carlos Vives - Nota de Amor (Official Video) ft. Daddy Yankee.mp3"},

        };

        Dictionary<int, string> rutaCancionesJesseJoy = new Dictionary<int, string>()
        {
             {0, @"C:\Rockola\Rockola\MUSICA\JesseJoy\Jesse & Joy - No Soy Una de Esas ft. Alejandro Sanz (Video Oficial).mp3"},
             {1, @"C:\Rockola\Rockola\MUSICA\JesseJoy\Sofia Reyes - Solo Yo (feat. Prince Royce) (Official Video).mp3"},
        };

        Dictionary<int, string> rutaCancionesMana = new Dictionary<int, string>()
        {
             {0, @"C:\Rockola\Rockola\MUSICA\Mana\Maná - Mi Verdad a dueto con Shakira (Video Oficial).mp3"},
             {1, @"C:\Rockola\Rockola\MUSICA\Mana\Prince Royce - Back It Up ft. Jennifer Lopez, Pitbull.mp3"},
        };
    }
}
