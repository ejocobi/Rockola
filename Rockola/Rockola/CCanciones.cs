using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockola
{
    class CCanciones
    {
        //Metedo para obtener canciones del arista
       
            public string[] ObtenerCanciones(int indice)
            {
                string[] cancionesCarlos = { "Bailar Contigo", "Como Le Gusta A Tu Cuerpo", "Cuando Nos Volvamos a Encontra", "Volví a Nacer." };
                string[] cancionesJbalvin = { "6 AM ", "Desde Esa Noche", "Nota de Amor" };
                string[] cancionesJesse = { "No Soy Una de Esas", "Solo Yo"};
                string[] cancionesMana = { "Mi Verdad ", "Back It Up"};
                string[] lista = { };
                
                if (indice == 0)
                {
                    lista = cancionesCarlos;
                }
                if (indice == 1)
                {
                    lista = cancionesJbalvin;
                }
                if (indice == 2)
                {
                    lista = cancionesJesse;
                }
                if (indice == 3)
                {
                    lista = cancionesMana;
                }

                 return lista;

            }
    }
}
