// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela(nombre: "Academia", 2012, "Mexico", "Nayarit");
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        Console.WriteLine(escuela);
    }
}