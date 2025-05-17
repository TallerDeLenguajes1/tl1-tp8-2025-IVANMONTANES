namespace EspacioTareas
{
    public class Tarea{
        // campos //
        private int tareaId;
        private string descripcion;
        private int duracion;

        // propiedades //
        public int TareaId {get => tareaId; set => tareaId = value;}
        public string Descripcion {get => descripcion; set => descripcion = value;}
        public int Duracion {get => duracion; set => duracion = value;}

        // metodos //
        // constructor //
        public Tarea(int tareaId, string descripcion, int duracion)
        {
            this.tareaId = tareaId;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

    }
}