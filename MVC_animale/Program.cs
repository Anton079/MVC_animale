using MVC_animale;

internal class Program
{
    public static void Main(string[] args)
    {

        AnimaleService service = new AnimaleService();

        service.LoadData();

        service.AfisareAnimale();

        Console.WriteLine("========");
        Animale Anim = service.FindAnimalVarstaMaxima();
        Console.WriteLine(Anim.AnimaleInfo());
        Console.WriteLine("========");

        List<Animale> animales = service.FilterAnimalsByType("Leu");
        foreach(Animale x in animales)
        {
            Console.WriteLine(x.AnimaleInfo());
        }
    }
}