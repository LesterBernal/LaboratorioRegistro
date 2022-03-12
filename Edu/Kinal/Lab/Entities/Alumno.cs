using LaboratorioRegistro.Edu.Kinal.Lab.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.Lab.Entities

{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia alumno: {this.Apellidos} {this.Nombres} con carné: {this.Carne}");
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"Datos Generales del alumno: UUID: {this.UUID}, Apellidos: {this.Apellidos}, Nombres: {this.Nombres}, Número de Créditos {this.NumeroCreditos}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura del alumno {this.Apellidos} {this.Nombres}, perdera la cantidad de créditos {this.NumeroCreditos}");
            return true;
        }

        public Alumno()
        {
        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
    }
}