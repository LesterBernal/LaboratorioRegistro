using LaboratorioRegistro.Edu.Kinal.Lab.Entities;
﻿using LaboratorioRegistro.Edu.Kinal.Lab.Interfaces;
public class Program
{
    private static List<Persona> ListaGeneral = new List<Persona>();
    public static void Main(string[] args)
    {

        Alumno JuanPerez = new Alumno("123","Perez Alvarez","Juan Alberto","jperez@kalum.edu.gt","2022001",30);
        Profesor EdwinTumax = new Profesor("767","Mancilla Paz","Raul Antonio","rmancilla@kalum.edu.gt","2489392620102","Instructor de informática");

        Console.WriteLine("Procesando registro de datos");
        OperarRegistro(JuanPerez);
        OperarRegistro(EdwinTumax);
        Console.WriteLine("Registrar asistencia");
        RegistrarAsistencia(JuanPerez);
        RegistrarAsistencia(EdwinTumax);
        Console.WriteLine("Mostrando datos");
        VerMisDatos(JuanPerez);
        VerMisDatos(EdwinTumax);
        Console.WriteLine("Eliminando asignaturas");
        QuitarAsignatura(JuanPerez,"Matematica");
        QuitarAsignatura(EdwinTumax,"Informática");

    }

    public static void VerMisDatos(Persona elemento)
    {
        if(elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        }else if(elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListarMisDatos(auxiliar.Cui);
        }
    }

    public static void RegistrarAsistencia(Persona elemento)
    {
        foreach(Persona registro in ListaGeneral)
        {
            if(registro.Uuid == elemento.Uuid)
            {
                elemento.TomarAsistencia();                
            }
        }
    }

    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }

    public static void OperarRegistro(Persona elemento)
    {
        ListaGeneral.Add(elemento);
    }
}
