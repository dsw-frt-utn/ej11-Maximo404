namespace Dsw2026Ej11.Collections;
using Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> RetornarAlumnos()
    {
        return alumnos;
    }

    public Alumno? BuscarAlumno(string nombreAlumno)
    {
        Alumno? alumno = null;

        foreach(Alumno a in alumnos)
        {
            if(a.Nombre == nombreAlumno)
            {
                alumno = a;
                return alumno;
            }
        }

        return alumno;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    public void EliminarAlumnoEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
    }
}