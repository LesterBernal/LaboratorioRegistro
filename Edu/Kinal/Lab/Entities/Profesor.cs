using LaboratorioRegistro.Edu.Kinal.Lab.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui {get;set;}
        public string Cargo {get;set;}

        public Profesor() : base()
        {
            
        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
            : base(uuid, apellidos, nombres, email)
        {
            this.Cui = cui;
            this.Cargo = cargo;
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha elminado la asignatura {this.Apellidos} {this.Nombres}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.Uuid} {this.Apellidos} {this.Nombres} {this.Cargo}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando Asistencia de {this.Apellidos} {this.Nombres}");
        }
    }
}
