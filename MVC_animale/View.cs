using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_animale
{
    public class View
    {

        AnimaleService animaleService = new AnimaleService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate Animalele");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate animalele cu greutatea mai mare de 5");
            Console.WriteLine("Apasati tasta 3 si introduceti animalul pe care il doriti sa il luati");
            Console.WriteLine("Apasati tasta 4 pentru adaugarea unui animal nou");
            Console.WriteLine("Apasati tasta 5 pentru stergerea unui animal");
            Console.WriteLine("EDIT ANIMALE:");
            Console.WriteLine("Apasati tasta 6 pentru a edita varsta unui animal anume");
            Console.WriteLine("Apasati tasta 7 pentru a edita inaltimea unui animal anume");
            Console.WriteLine("Apasati tasta 8 pentru a edita culoare unui animal anume");
            Console.WriteLine("Apasati tasta 9 pentru a edita latime unui animal anume");
            Console.WriteLine("Apasati tasta 10 pentru a edita greutate unui animal anume");
            Console.WriteLine("Filtrare:");
            Console.WriteLine("Apasati tasta 11 si inserati ce tip de animal cautati in lista");


        }
        public void Play()
        {
            bool running = true;

            animaleService.LoadData();
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        animaleService.AfisareAnimale();
                        break;

                    case "2":
                        animaleService.AfisareaAnimalelorGrele();
                        break;

                    case "3":

                        AdoptareaAnimalelor();
                        break;

                    case "4":
                        AdaugareaUnuiAnimal();
                        break;

                    case "5":
                        StergereaUnuiAnimalului();
                        break;

                    case "6":
                        EditVarstaAnimal();
                        break;

                    case "7":
                        EditInaltimeAnimale();
                        break;

                    case "8":
                        EditCuloareAnimal();
                        break;

                    case "9":
                        EditLatimeAnimal();
                        break;

                    case "10":
                        EditGreutateAnimal();
                        break;

                    case "11":
                        FiltrareTipuriAnimale();
                        break;

                }

            }

        }

        public void AdoptareaAnimalelor()
        {
            Console.WriteLine("Introduceti animalul dorit din lista de mai jos in text");
            string animalDorit = Console.ReadLine();

            animaleService.AdoptareaUnuiAnimal(animalDorit);

        }

        public void AdaugareaUnuiAnimal()
        {
            Console.WriteLine("Inaltimea cainelui");
            int inaltimeNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tipul de animal");
            string animalNou = Console.ReadLine();

            Console.WriteLine("Culoarea");
            string culoareNou = Console.ReadLine();

            Console.WriteLine("Greutate");
            int greutateNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Latime");
            int latimeNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Varsta");
            int varstaNou = Int32.Parse(Console.ReadLine());

            Animale animal7 = new Animale();
            animal7.inaltime = inaltimeNou;
            animal7.tipAnimal = animalNou;
            animal7.culoare = culoareNou;
            animal7.greutate = greutateNou;
            animal7.latime = latimeNou;
            animal7.varsta = varstaNou;

            Console.WriteLine("Animalul a fost adaugat cu succes");
        }

        public void StergereaUnuiAnimalului()
        {
            Console.WriteLine("Din lista de mai jos ce animal doiriti sa stergeti");
            animaleService.AfisareAnimale();
            string AnimaleDorite = Console.ReadLine();

            if (animaleService.FindAnimalByTipAnimal(AnimaleDorite) != -1)
            {
                animaleService.RemoveAnimalByTipAnimal(AnimaleDorite);
                Console.WriteLine("Animalul a fost sters!");
            }
            else
            {
                Console.WriteLine("Animalul nu exista");

            }
        }

        //EDIT ANIMALE
        public void EditVarstaAnimal()
        {
            Console.WriteLine("La ce animal doriti sa modificati varsta?");
            string animalNewAge = Console.ReadLine();

            Console.WriteLine("Cu ce varsta vreti sa ii modificati?");
            int newAge = Int32.Parse(Console.ReadLine());

            if(animaleService.EditAnimalAge(animalNewAge, newAge))
            {
                Console.WriteLine("Varsta animalului a fost modificata cu succes!");
            }
            else
            {
                Console.WriteLine("Varsta animalului nu a putut fi modificata!");
            }
        }

        public void EditInaltimeAnimale()
        {
            Console.WriteLine("Ce animal doriti sa editati");
            string wantedAnimal= Console.ReadLine();

            Console.WriteLine("Cu ce inaltime doriti sa modificati animalul");
            int animalNewHigh = Int32.Parse(Console.ReadLine());

            if(animaleService.EditAnimalHigh(animalNewHigh, wantedAnimal))
            {
                Console.WriteLine("Animalul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Animalul nu a putut fi editat");
            }
        }

        public void EditCuloareAnimal()
        {
            Console.WriteLine("Ce animal vrei sa modifici la culoare?");
            string wantedAnimal= Console.ReadLine();

            Console.WriteLine("Ce culoare vrei sa modifici la animal?");
            string newCuloare = Console.ReadLine();

            if(animaleService.EditAnimalColour(newCuloare, wantedAnimal))
            {
                Console.WriteLine("Animalul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Animalul nu a putut fi editat");
            }
        }

        public void EditLatimeAnimal()
        {
            Console.WriteLine("Ce animal doriti sa editati");
            string wantedAnimal= Console.ReadLine();

            Console.WriteLine("Cu ce latime vreti sa modifi animalul");
            int newLatime = Int32.Parse(Console.ReadLine());

            if(animaleService.EditAnimalLatie(wantedAnimal, newLatime))
            {
                Console.WriteLine("Animalul a fost modificat cu succes");
            }
            else
            {
                Console.WriteLine("Animalul nu a putut fi modificat");
            }
        }

        public void EditGreutateAnimal()
        {
            Console.WriteLine("Ce animal doriti sa modificati");
            string wantedAnimal= Console.ReadLine();

            Console.WriteLine("Cu ce greutate doriti sa modificati la animal");
            int newGreutate = Int32.Parse(Console.ReadLine());

            if(animaleService.EditAnimalGreutate(wantedAnimal, newGreutate))
            {
                Console.WriteLine("Modificarea a reusit");
            }
            else
            {
                Console.WriteLine("Modificarea nu a reusit");
            }
        }

        //FILTRARE

        public void FiltrareTipuriAnimale()
        {
            Console.WriteLine("Ce tip de animale cautati");
            string wantedAnimal= Console.ReadLine();

            if(animaleService.FiltrareTipAnimale(wantedAnimal))
            {
                Console.WriteLine($"Animalele de acelasi tip:");
            }
            else
            {
                Console.WriteLine("Nu s au gasit animale de acest tip");
            }
        }
        
    }
}
