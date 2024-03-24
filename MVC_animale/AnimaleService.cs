using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MVC_animale
{
    public class AnimaleService
    {
        private List<Animale> _AnimaleList;

        public AnimaleService()
        {
            _AnimaleList  = new List<Animale>();
            this.LoadData();
        }

        public void LoadData()
        {
            Animale animal1 = new Animale();
            animal1.Inaltime = 2;
            animal1.Latime = 2;
            animal1.Culoare = "Negru";
            animal1.Greutate = 10;
            animal1.TipAnimal = "Leu";
            animal1.Varsta = 11;
            
            Animale animal2 = new Animale();
            animal2.Latime = 3;
            animal2.Inaltime = 4;
            animal2.Greutate = 5;
            animal2.Culoare = "Verde";
            animal2.TipAnimal = "Urs";
            animal2.Varsta = 6;

            Animale animal3 = new Animale();
            animal3.Inaltime = 4;
            animal3.Latime = 3;
            animal3.Greutate = 15;
            animal3.Culoare = "Alb";
            animal3.TipAnimal = "Lup Polar";
            animal3.Varsta = 12;

            Animale animal4 = new Animale();
            animal4.Inaltime = 7;
            animal4.Latime = 10;
            animal4.Greutate = 3;
            animal4.Culoare = "Albastru";
            animal4.TipAnimal = "Caine";
            animal4.Varsta = 15;

            Animale animal5 = new Animale();
            animal5.Inaltime = 1;
            animal5.Latime = 2;
            animal5.Greutate = 1;
            animal5.Culoare = "Maro";
            animal5.TipAnimal = "Hamster";
            animal5.Varsta = 20;

            Animale animal6 = new Animale();
            animal6.Inaltime = 3;
            animal6.Latime = 4;
            animal6.Greutate = 1;
            animal6.Culoare = "Negru";
            animal6.TipAnimal = "Lup";
            animal6.Varsta = 19;

            Animale animal7 = new Animale();
            animal7.Inaltime = 5;
            animal7.Latime = 32;
            animal7.Culoare = "Galben";
            animal7.Greutate = 10;
            animal7.TipAnimal = "Leu";
            animal7.Varsta = 17;

            Animale animal8 = new Animale();
            animal8.Inaltime = 61;
            animal8.Latime = 61;
            animal8.Culoare = "Verde";
            animal8.Greutate = 423;
            animal8.TipAnimal = "Leu";
            animal8.Varsta = 5474;

            this._AnimaleList.Add(animal1);
            this._AnimaleList.Add(animal2);
            this._AnimaleList.Add(animal3);
            this._AnimaleList.Add(animal4);
            this._AnimaleList.Add(animal5);
            this._AnimaleList.Add(animal6);
            this._AnimaleList.Add(animal7);
            this._AnimaleList.Add(animal8);
            
        }

        public void AfisareAnimale()
        {
            foreach(Animale x in _AnimaleList)
            {
                Console.WriteLine(x.AnimaleInfo());
            }
        }


        //functie pentru afisarea animalului cu varsta ce-a mai mare
        public Animale FindAnimalVarstaMaxima()
        {
            int varstaMaxima = 0;
            Animale tipAnimal = _AnimaleList[0];
            foreach(Animale x in _AnimaleList)
            {
                if(x.Varsta > varstaMaxima)
                {
                    varstaMaxima = x.Varsta;
                    tipAnimal = x;
                }
            }
            return tipAnimal;
        }

        //functie pentru afisarea tuturor obiector ce contin acelasi animal
        public List <Animale> FilterAnimalsByType(string Leu)
        {
            List<Animale> animList = new List<Animale>();
             
            foreach(Animale x in _AnimaleList)
            {
                if(Leu.Equals(x.TipAnimal))
                {
                    animList.Add(x);
                }
            }
            return animList;
        }


        //functie pentru sortarea animalelor dupa inaltime
        public void SortAnimaleByHigh()
        {
           
            //i=0   j=1 i=0 
            for(int i = 0;  i < _AnimaleList.Count; i++)
            {
                for(int j=i+1;j < _AnimaleList.Count; j++)
                {
                    if (_AnimaleList[i].Inaltime > _AnimaleList[j].Inaltime)
                    {

                        Animale aux = _AnimaleList[i];
                        _AnimaleList[i] = _AnimaleList[j];
                        _AnimaleList[j] = aux;


                    }
                }
            }
           

        }

        //todo verifica daca obiectul se afla in lista
        public  bool EraseAnimalByName(string numeAnimal)
        {

            int index = FindAnimalPositionByName(numeAnimal);


            if(index != -1)
            {
                _AnimaleList.RemoveAt(index);

                return true;
            }

            return false;
        
        }

        //todo functie ce primeste ca parametru numele animalului si returneaza pozitia din linsta
        public int FindAnimalPositionByName(string numeAnimal)
        {
           
            for(int i = 0; i < _AnimaleList.Count; i++)
            {
                if (_AnimaleList[i].TipAnimal.Equals(numeAnimal))
                {
                    return i;
                }
            }

            return -1;
        }




        //FUNCTII CRUD

        //todo: functie de editatare varsta animal
        public bool EditAnimalAge(string animal ,int varsta)
        {
            foreach(Animale x in _AnimaleList)
            {
                if(x.TipAnimal == animal)
                {
                    x.Varsta = varsta;
                    return true;
                }
            }
            

            return false;
        }

        public bool EditAnimalHigh(int inaltime, string animal)
        {
            foreach (Animale x in _AnimaleList)
            {
                if (x.TipAnimal == animal)
                {
                    x.Inaltime = inaltime;
                    return true;
                }

            }
            return false;
        }


        //CRUD  functionalities   create read update delete 

        public int FindAnimalByTipAnimal(string animalCautat)
        {
            for(int i = 0; i < _AnimaleList.Count; i++)
            {
                if (_AnimaleList[i].TipAnimal.Equals(animalCautat))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddAnimalInList(Animale animalNou)
        {
            if (FindAnimalByTipAnimal(animalNou.TipAnimal) == -1)
            {
                this._AnimaleList.Add(animalNou);
                return true;
            }
            return false;
        }

        public bool RemoveAnimalByTipAnimal(string AnimalCauatat)
        {
            int AnimCautat = FindAnimalByTipAnimal(AnimalCauatat);
            if(AnimCautat != -1)
            {
                _AnimaleList.RemoveAt(AnimCautat);
                return true;
            }
            return false;
        }

        //VIEW
        public void AfisareaAnimalelorGrele()
        {
            for(int i = 0;i < _AnimaleList.Count; i++)
            {
                if (_AnimaleList[i].Greutate >= 12)
                {
                    Console.WriteLine(_AnimaleList[i].TipAnimal);
                }
            }
        }

        public bool AdoptareaUnuiAnimal(string animalDorit)
        {
            int poz = FindAnimalByTipAnimal(animalDorit);

            if(poz != -1)
            {
                _AnimaleList.RemoveAt(poz);
                return true;
            }
            return false;
        }

        public bool AdaugareaUnuiAnimal(Animale animal7)
        {
            for(int i = 0; i < _AnimaleList.Count; i++)
            {
                if (!_AnimaleList[i].Equals(animal7.TipAnimal))
                {
                    this._AnimaleList.Add(animal7);
                    return true;
                }
            }
            return false;
        }

        //EDIT ANIMALE
        public bool EditAnimalColour(string animal , string culoare)
        {
            foreach (Animale x in _AnimaleList)
            {
                if(x.TipAnimal == animal)
                {
                    x.Culoare = culoare;
                    return true;
                }
            }
         return false;
        }

        public bool EditAnimalLatie(string animal, int latime)
        {
            foreach(Animale x in _AnimaleList)
            {
                if (x.TipAnimal.Equals(animal))
                {
                    x.Latime = latime;
                    return true;
                }
            }
            return false;
        }

        public bool EditAnimalGreutate(string animal, int greutate)
        {
            foreach(Animale x in _AnimaleList)
            {
                if(x.TipAnimal == animal)
                {
                    x.Greutate = greutate;
                    return true;
                }
            }
            return false;
        }

        //FILTRARE
        public List<Animale> FiltrareTipAnimale(string animal)
        {
            List <Animale> FiltruAnimaleAsemanatoare = new List<Animale>();

            for (int i = 0; i < this._AnimaleList.Count; i++)
            {
                if (this._AnimaleList[i].TipAnimal.Equals(animal))
                {
                    FiltruAnimaleAsemanatoare.Add(_AnimaleList[i]);
                }
            }

            return FiltruAnimaleAsemanatoare;
        }

    }
}
