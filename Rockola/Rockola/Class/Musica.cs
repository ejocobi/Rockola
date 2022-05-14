using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockola.Class
{
    class Cantante
    {
        string[] nombreCancion = { "Bailar Contigo", "Como Le Gusta", " Cuando Nos Volvamos a Encontrar",
        "Volví a Nacer"};

        public string Nombre { get; set; }
    }

    class Musica : Cantante
    {
        string[] nom_cantante = { "Carlos Vives", "Jesse Joe", "Mana", "J Valvin" };
        

    }

    class Genero : Cantante
    {
        string[] genero = { "Pop", "Regueton", "Ballenato" };
    }
}
