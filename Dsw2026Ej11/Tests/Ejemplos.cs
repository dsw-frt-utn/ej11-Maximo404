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
        Alumno a1 = new Alumno(1, "Juan", 7.5);
        Alumno a2 = new Alumno(2, "Maria", 8.0);
        Alumno a3 = new Alumno(3, "Pedro", 6.5);

        CasoDictionary diccionarioAlumnos = new CasoDictionary();

        diccionarioAlumnos.AgregarAlumno(111, a1);
        diccionarioAlumnos.AgregarAlumno(222, a2);
        diccionarioAlumnos.AgregarAlumno(333, a3);

        Console.WriteLine("Alumnos en el diccionario:");
        foreach (KeyValuePair<int, Alumno> alumno in diccionarioAlumnos.ObtenerAlumnos())
        {
            Console.WriteLine(alumno.Value.ToString());
        }

        Console.WriteLine(diccionarioAlumnos.BuscarAlumno(111)?.ToString() ?? "No existe");
        Console.WriteLine(diccionarioAlumnos.BuscarAlumno(444)?.ToString() ?? "No existe");
        diccionarioAlumnos.EliminarAlumno(222);
        Console.WriteLine("Alumnos en el diccionario despues de eliminar uno:");
        foreach (KeyValuePair<int, Alumno> a in diccionarioAlumnos.ObtenerAlumnos())
        {
            Console.WriteLine(a.Value.ToString());
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("Ejemplo LINQ:");
        List<Libro> libros = Libro.CrearLista();

        CasoLinq listaLibros = new CasoLinq(libros);


        Console.WriteLine(listaLibros.GetPrimero()?.ToString() ?? "No existe");

        Console.WriteLine(listaLibros.GetUltimo()?.ToString() ?? "No existe");

        Console.WriteLine($"Total de precios: {listaLibros.GetTotalPrecios():C}");

        Console.WriteLine($"Promedio de precios: {listaLibros.GetPromedioPrecios():C}");

        Console.WriteLine("Libros con Id mayor a 15:");
        foreach (Libro l in listaLibros.GetListById())
        {
            Console.WriteLine(l.ToString());
        }

        Console.WriteLine("Lista de libros:");
        foreach (string s in listaLibros.GetLibros())
        {
            Console.WriteLine(s);
        }

        Console.WriteLine($"Libro con mayor precio: {listaLibros.GetMayorPrecio():C}");

        Console.WriteLine($"Libro con menor precio: {listaLibros.GetMenorPrecio():C}");

        Console.WriteLine("Lista de libros con precios mayor al promedio:");
        foreach (Libro l in listaLibros.GetMayorPromedio())
        {
            Console.WriteLine(l.ToString());
        }

        Console.WriteLine("Lista de libros ordenados descendetemente por título:");
        foreach (Libro l in listaLibros.GetLibrosOrdenadosDescPorTitulo())
        {
            Console.WriteLine(l.ToString());
        }
    }
}
