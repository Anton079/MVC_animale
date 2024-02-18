using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_animale
{
    public class Animale
    {
        public int inaltime;
        public string tipAnimal;
        public string culoare;
        public int greutate;
        public int latime;
        public int varsta;

        public string AnimaleInfo()
        {
            string text = " ";
            text += "Inaltimea" + inaltime + "\n";
            text += "Animalul" + tipAnimal + "\n";
            text += "Culoare" + culoare + "\n";
            text += "Greutate" + greutate + "\n";
            text += "Latime" + latime + "\n";
            text += "Varsta" + varsta + "\n";
            return text;
        }
    }
}
