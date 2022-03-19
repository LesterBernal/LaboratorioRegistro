using LaboratorioRegistro.Edu.Kinal.Lab.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.Lab.Entities;


public class Alumno : Persona, IOperaciones
{
    public string Carne {get;set;}
    public int NumeroCreditos {get;set;}

    public Alumno() : base()
    {
        
    }
    public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        : base(uuid, apellidos, nombres, email)
    {
        this.Carne = carne;
        this.NumeroCreditos = numeroCreditos;
    }
    public bool EliminarAsignatura(string asignatura)
    {
        Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos} {this.Nombres}, Perdera la cantidad de creditos de {this.NumeroCreditos}");
        return true;
    }

    public void ListarMisDatos(string identificador)
    {
        Console.WriteLine($"{this.Uuid} {this.Apellidos} {this.Nombres} {this.NumeroCreditos}");
    }

    public override void TomarAsistencia()
    {
        Console.WriteLine($"Tomando Asistencia de {this.Apellidos} {this.Nombres}");
    }
}
