namespace Dsw2026Ej11.Collections;

using Domain;
using System.Linq;  

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros;

    public CasoLinq(List<Libro> libros)
    {
        this.libros = libros;
    }

    public Libro? GetPrimero()
    {
        return libros.FirstOrDefault();
    }

    public Libro? GetUltimo()
    {
        return libros.LastOrDefault();
    }

    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio);
    }

    public decimal GetPromedioPrecios()
    {
        return libros.Average(l => l.Precio);
    }

    public List<Libro> GetListById()
    {
        List<Libro> list = new List<Libro>();
        list = libros.Where(l => l.Id > 15).ToList(); //El ToList() es necesario para convertir el resultado de Where a una lista de libros
        return list;
    }

    public List<string> GetLibros()
    {
        List<string> list = new List<string>();
        //Utilizamos el método Select para proyectar cada libro a un string con su título y precio formateado como moneda
        list = libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList(); //El :C es para formatear el precio como moneda
        return list;
    }

    public Libro? GetMayorPrecio()
    {
        return libros.OrderByDescending(l => l.Precio).FirstOrDefault(); //Ordenamos los libros por precio de forma descendente y obtenemos el primero
    }

    public Libro? GetMenorPrecio()
    {
        return libros.OrderByDescending(l => l.Precio).LastOrDefault(); //Ordenamos los libros por precio de forma descendente y obtenemos el último
    }

    public List<Libro>? GetMayorPromedio()
    {
        decimal promedio = libros.Average(l => l.Precio); //Calculamos el promedio de precios
        return libros.Where(l => l.Precio > promedio).ToList(); //Obtenemos los libros cuyo precio es mayor al promedio
    }

    public List<Libro>? GetLibrosOrdenadosDescPorTitulo()
    {
        return libros.OrderByDescending(l => l.Titulo).ToList(); //Ordenamos los libros por título de forma descendente
    }
}
