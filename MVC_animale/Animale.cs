using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_animale
{
    public class Animale
    {
        public int _inaltime;
        public string _tipAnimal;
        public string _culoare;
        public int _greutate;
        public int _latime;
        public int _varsta;

        public int Inaltime
        {
            get { return _inaltime; }
            set { _inaltime = value; }
        }

        public string TipAnimal
        {
            get { return _tipAnimal; }
            set { _tipAnimal = value; }
        }

        public string Culoare
        {
            get { return _culoare; }
            set { _culoare = value; }
        }

        public int Greutate
        {
            get { return _greutate; }
            set { _greutate = value; }
        }

        public int Latime
        {
            get { return _latime; }
            set { _latime = value; }
        }

        public int Varsta
        {
            get { return _varsta; }
            set { _varsta = value; }
        }

        public string AnimaleInfo()
        {
            string text = " ";
            text += "Inaltimea" + Inaltime + "\n";
            text += "Animalul" + TipAnimal + "\n";
            text += "Culoare" + Culoare + "\n";
            text += "Greutate" + Greutate + "\n";
            text += "Latime" + Latime + "\n";
            text += "Varsta" + Varsta + "\n";
            return text;
        }
    }
}
