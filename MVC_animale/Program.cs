using MVC_animale;
using System.ComponentModel.Design;

internal class Program
{
    public static void Main(string[] args)
    {

        AnimaleService service = new AnimaleService();

        View view = new View();
        service.LoadData();



        view.Play();


    }
}