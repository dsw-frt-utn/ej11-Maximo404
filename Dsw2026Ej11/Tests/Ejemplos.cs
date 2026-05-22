using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Alumno a1 = new Alumno(1, "Juan", 7.5);
        Alumno a2 = new Alumno(2, "Maria", 8.0);
        Alumno a3 = new Alumno(3, "Pedro", 6.5);

        CasoList listaAlumnos = new CasoList();
        listaAlumnos.AgregarAlumno(a1);
        listaAlumnos.AgregarAlumno(a2);
        listaAlumnos.AgregarAlumno(a3);

        List<Alumno> alumnos = listaAlumnos.RetornarAlumnos();
        Console.WriteLine("Alumnos en la lista:");
        foreach(Alumno a in alumnos)
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine(listaAlumnos.BuscarAlumno("Juan")?.ToString() ?? "No existe");

        Console.WriteLine(listaAlumnos.BuscarAlumno("Ana")?.ToString() ?? "No existe");

        listaAlumnos.EliminarAlumno(a2);
        Console.WriteLine("Alumnos en la lista despues de eliminar uno:");
        foreach (Alumno a in alumnos)
        {
            Console.WriteLine(a.ToString());
        }

        listaAlumnos.EliminarAlumnoEnPosicion(0);
        Console.WriteLine("Alumnos en la lista despues de eliminar el primer elemento:");
        foreach (Alumno a in alumnos)
        {
            Console.WriteLine(a.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
