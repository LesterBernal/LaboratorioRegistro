using LaboratorioRegistro.Edu.Kinal.Lab.Entities;
public class Sistema
{
    public static void Main(string[] args)
    {
        List<Persona> ListaGeneral = new List<Persona>();

        Alumno alumno = new Alumno(Guid.NewGuid().ToString(), "Payeras", "Bernardino", "payeras@gmail.com", "2022-001", 100);
        Alumno alumno2 = new Alumno(Guid.NewGuid().ToString(), "Medina", "Daniel", "dmedina@gmail.com", "2022-002", 90);
        Profesor profesor = new Profesor(Guid.NewGuid().ToString(), "Tumax", "Edwin", "tumax@gmail.com", "2549 78885 0101", "Profesor Programacion");
        Profesor profesor2 = new Profesor(Guid.NewGuid().ToString(), "Giron", "Gerardo", "giron@gmail.com", "5454 87268 0101", "Profesor de Matematicas");

        ListaGeneral.Add(alumno);
        ListaGeneral.Add(alumno2);
        ListaGeneral.Add(profesor);
        ListaGeneral.Add(profesor2);

        OperarRegistro(ListaGeneral);
        RegistarAsistencia(ListaGeneral);
        VerMisDatos(ListaGeneral);
        QuitarAsignatura(ListaGeneral);

    }
    static void OperarRegistro(List<Persona> elemento)
    {
        Console.WriteLine($"REGISTRO GENERAL");
        foreach (Persona persona in elemento)
        {
            if (persona is Alumno)
            {
                Console.WriteLine($"Registro de alumno: {persona.Nombres} {persona.Apellidos} con carné: {((Alumno)persona).Carne}");
            }
            else if (persona is Profesor)
            {
                Console.WriteLine($"Registro de Profesor: {persona.Nombres} {persona.Apellidos} con cargo: {((Profesor)persona).Cargo}");
            }
        }
    }
    static void RegistarAsistencia(List<Persona> elemento)
    {
        Console.WriteLine($"RRGISTRO DE ASISTENCIA");
        foreach (Persona persona in elemento)
        {
            persona.TomarAsistencia();
        }
    }

    static void VerMisDatos(List<Persona> elemento)
    {
        Console.WriteLine($"DATOS PERSONALES");
        foreach (Persona persona in elemento)
        {
            if (persona is Alumno)
            {
                ((Alumno)persona).ListarMisDatos(((Alumno)persona).Carne);
            }
            else if (persona is Profesor)
            {
                ((Profesor)persona).ListarMisDatos(((Profesor)persona).CUI);
            }
        }
    }
    static void QuitarAsignatura(List<Persona> elemento)
    {
        Console.WriteLine($"QUITAR ASIGNATURA");
        foreach (Persona persona in elemento)
        {
            if (persona is Alumno)
            {
                ((Alumno)persona).EliminarAsignatura(((Alumno)persona).Carne);
            }
            else if (persona is Profesor)
            {
                ((Profesor)persona).EliminarAsignatura(((Profesor)persona).CUI);
            }
        }
    }


}