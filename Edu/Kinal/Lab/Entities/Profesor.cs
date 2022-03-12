using LaboratorioRegistro.Edu.Kinal.Lab.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI { get; set; }
        public string Cargo { get; set; }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia Profesor: {this.Apellidos} {this.Nombres} con cargo: {this.Cargo}"); ;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"Datos Generales del profesor: UUID: {this.UUID}, Apellidos: {this.Apellidos}, Nombres: {this.Nombres}, Cargo: {this.Cargo}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura del profesor {this.Apellidos} {this.Nombres}");
            return true;
        }

        public Profesor()
        {
        }
        public Profesor(string uuid, string apellidos, string nombres, string email, string CUI, string Cargo)
        : base(uuid, apellidos, nombres, email)
        {
            this.CUI = CUI;
            this.Cargo = Cargo;
        }
    }
}