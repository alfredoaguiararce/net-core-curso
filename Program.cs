// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var escuela = new Escuela(nombre: "Academia", 2012, "Mexico", "Nayarit");
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        Console.WriteLine(escuela);

        var curso_1 = new Curso()
        {
            Nombre = " 101"
        };
        var curso_3 = new Curso()
        {
            Nombre = " 102"
        };
        var curso_2 = new Curso()
        {
            Nombre = " 301"
        };

        var arregloCursos = new Curso[3];
        arregloCursos[0] = curso_1;
        arregloCursos[1] = curso_2;
        arregloCursos[2] = curso_3;


        System.Console.WriteLine("=============");
        System.Console.WriteLine(curso_1.Nombre + " , " + curso_1.UniqueId);
        System.Console.WriteLine(curso_2.Nombre + " , " + curso_2.UniqueId);
        System.Console.WriteLine(curso_3.Nombre + " , " + curso_3.UniqueId);

        // ImprimirCursos(arregloCursos);


        var escuela_ = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        ciudad: "Bogotá", pais: "Colombia"
                        );

        escuela_.Cursos = new Curso[]{
                    new Curso(){ Nombre = "101"},
                    new Curso() {Nombre = "201"},
                    new Curso{Nombre = "301"}
        };


        bool rta = 10 == 10;//true
            int cantidad = 10;

            if (rta == false)
            {
                WriteLine("Se cumplio la condición #1");
            }
            else if (cantidad > 15)
            {
                WriteLine("Se cumplio la condición #2");
            }
            else
            {
                WriteLine("NO Se cumplio la condición");
            }

            if(cantidad > 5 && rta == false)
            {
                WriteLine("Se cumplio la condición #3");
            }

            
            if(cantidad > 5 && rta )
            {
                WriteLine("Se cumplio la condición #4");
            }

            cantidad = 10;
            if(
                (cantidad > 15 || !rta) 
                && (cantidad % 5 == 0 )
            )
            {
                WriteLine("Se cumplio la condición #5");
            }


    }

    // private static void ImprimirCursos(Curso[] arregloCursos)
    // {
    //         WriteLine("====================");
    //         WriteLine("Cursos de la Escuela");
    //         WriteLine("====================");

    //         if (escuela?.Cursos != null)
    //         {
    //             foreach (var curso in escuela.Cursos)
    //             {
    //                 WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
    //             }
    //         }
    // }

    private static void ImprimirCursosWhile(Curso[] arregloCursos)
    {
        int contador = 0;
        while (contador < arregloCursos.Length)
        {
            Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id  {arregloCursos[contador].UniqueId}");
            contador++;
        }
    }

    private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
    {
        int contador = 0;
        do
        {
            Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id  {arregloCursos[contador].UniqueId}");
            contador++;
        } while (contador < arregloCursos.Length);
    }

    private static void ImprimirCursosFor(Curso[] arregloCursos)
    {
        for (int i = 0; i < arregloCursos.Length; i++)
        {
            Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id  {arregloCursos[i].UniqueId}");
        }
    }

    private static void ImprimirCursosForEach(Curso[] arregloCursos)
    {
        foreach (var curso in arregloCursos)
        {
            Console.WriteLine($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");
        }
    }
}