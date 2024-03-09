using MVC_animale;
using System.ComponentModel.Design;

internal class Program
{
    public static void Main(string[] args)
    {

        AnimaleService service = new AnimaleService();

        service.LoadData();
        View view = new View();


        Animale Animal7 = new Animale();
        Animal7.varsta = 7;
        Animal7.latime = 2;
        Animal7.inaltime= 3;
        Animal7.culoare = "Albastru";
        Animal7.tipAnimal = "Peste";
        Animal7.greutate = 10;

        bool t = service.AddAnimalinList(Animal7);

        view.Play();


    }
}