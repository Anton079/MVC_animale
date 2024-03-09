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
        public List<Animale> AnimaleList = new List<Animale>();

        public void LoadData()
        {
            Animale animal1 = new Animale();
            animal1.inaltime = 2;
            animal1.latime = 2;
            animal1.culoare = "Negru";
            animal1.greutate = 10;
            animal1.tipAnimal = "Leu";
            animal1.varsta = 11;
            
            Animale animal2 = new Animale();
            animal2.latime = 3;
            animal2.inaltime = 4;
            animal2.greutate = 5;
            animal2.culoare = "Verde";
            animal2.tipAnimal = "Urs";
            animal2.varsta = 6;

            Animale animal3 = new Animale();
            animal3.latime = 4;
            animal3.inaltime = 3;
            animal3.greutate = 10;
            animal3.culoare = "Alb";
            animal3.tipAnimal = "Lup Polar";
            animal3.varsta = 12;

            Animale animal4 = new Animale();
            animal4.latime = 7;
            animal4.inaltime = 10;
            animal4.greutate = 3;
            animal4.culoare = "Albastru";
            animal4.tipAnimal = "Caine";
            animal4.varsta = 15;

            Animale animal5 = new Animale();
            animal5.latime = 1;
            animal5.inaltime = 2;
            animal5.greutate = 1;
            animal5.culoare = "Maro";
            animal5.tipAnimal = "Hamster";
            animal5.varsta = 20;

            Animale animal6 = new Animale();
            animal6.latime = 3;
            animal6.inaltime = 4;
            animal6.greutate = 1;
            animal6.culoare = "Negru";
            animal6.tipAnimal = "Lup";
            animal6.varsta = 19;


            this.AnimaleList.Add(animal1);
            this.AnimaleList.Add(animal2);
            this.AnimaleList.Add(animal3);
            this.AnimaleList.Add(animal4);
            this.AnimaleList.Add(animal5);

            
        }

        public void AfisareAnimale()
        {
            foreach(Animale x in AnimaleList)
            {
                Console.WriteLine(x.AnimaleInfo());
            }
        }


        //functie pentru afisarea animalului cu varsta ce-a mai mare
        public Animale FindAnimalVarstaMaxima()
        {
            int varstaMaxima = 0;
            Animale tipAnimal = AnimaleList[0];
            foreach(Animale x in AnimaleList)
            {
                if(x.varsta > varstaMaxima)
                {
                    varstaMaxima = x.varsta;
                    tipAnimal = x;
                }
            }
            return tipAnimal;
        }

        //functie pentru afisarea tuturor obiector ce contin acelasi animal
        public List <Animale> FilterAnimalsByType(string Leu)
        {
            List<Animale> animList = new List<Animale>();
             
            foreach(Animale x in AnimaleList)
            {
                if(Leu.Equals(x.tipAnimal))
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
            for(int i = 0;  i < AnimaleList.Count; i++)
            {
                for(int j=i+1;j < AnimaleList.Count; j++)
                {
                    if (AnimaleList[i].inaltime > AnimaleList[j].inaltime)
                    {

                        Animale aux = AnimaleList[i];
                        AnimaleList[i] = AnimaleList[j];
                        AnimaleList[j] = aux;


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
                AnimaleList.RemoveAt(index);

                return true;
            }

            return false;
        
        }

        //todo functie ce primeste ca parametru numele animalului si returneaza pozitia din linsta
        public int FindAnimalPositionByName(string numeAnimal)
        {
           
            for(int i = 0; i < AnimaleList.Count; i++)
            {
                if (AnimaleList[i].tipAnimal.Equals(numeAnimal))
                {
                    return i;
                }
            }

            return -1;
        }

        //todo functie ce adauga un animal UNIC in lista
        public bool AddAnimalinList (Animale numeAnimal)
        {
            if (FindAnimalPositionByName(numeAnimal.tipAnimal)==-1)
            {
                
                this.AnimaleList.Add(numeAnimal);
                return true;
            }
            return false;
        }




        //FUNCTII CRUD

        //todo: functie de editatare varsta animal
        public bool EditAnimalAge(string animal ,int varsta)
        {
            foreach(Animale x in AnimaleList)
            {
                if(x.tipAnimal == animal)
                {
                    x.varsta = varsta;
                    return true;
                }
            }
            

            return false;
        }


        public bool EditAnimalHigh(int inaltime, string animal)
        {
            foreach (Animale x in AnimaleList)
            {
                if (x.tipAnimal == animal)
                {
                    x.inaltime = inaltime;
                    return true;
                }

            }
            return false;
        }

        //CRUD  functionalities   create read update delete 

        public int FindAnimalByTipAnimal(string animalCautat)
        {
            for(int i = 0; i < AnimaleList.Count; i++)
            {
                if (AnimaleList[i].tipAnimal.Equals(animalCautat))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddMasinaInList(Animale animalNou)
        {
            if (FindAnimalByTipAnimal(animalNou.tipAnimal) == -1)
            {
                this.AnimaleList.Add(animalNou);
                return true;
            }
            return false;
        }

        public bool RemoveAnimalByTipAnimal(string AnimalCauatat)
        {
            int AnimCautat = FindAnimalByTipAnimal(AnimalCauatat);
            if(AnimCautat != -1)
            {
                AnimaleList.RemoveAt(AnimCautat);
                return true;
            }
            return false;
        }

        //VIEW
        public void AfisareaAnimalelorGrele()
        {
            for(int i = 0;i < AnimaleList.Count; i++)
            {
                if (AnimaleList[i].greutate >= 3)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public string AdoptareaUnuiAnimal(string animalDorit)
        {
            int poz = FindAnimalByTipAnimal(animalDorit);
            
           return
        }
    }
}
