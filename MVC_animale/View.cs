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
                        animaleService.AdoptareaUnuiAnimal();
                        break;

                    case "4":
                        animaleService.AdaugareaUnuiAnimal();
                        break;
                }

            }

        }

        public void AdoptareaAnimalelor()
        {
            Console.WriteLine("Introduceti animalul dorit din lista de mai jos in text");
            animaleService.AfisareAnimale();
            string dorit = Console.ReadLine();

        }
    }   
}
