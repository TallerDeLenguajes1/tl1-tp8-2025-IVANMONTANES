namespace EspacioCalculadora{

    public enum TipoOperacion {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }

    public class Operacion{
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;
        public double resultado;

        // constructor //
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }

        // metodo para mostrar la operacion //
        public void MostrarOperacion(){
            Console.WriteLine("====================== OPERACION ======================");
            Console.WriteLine($"Operacion: {operacion}");
            Console.WriteLine($"Resultado Anterior = {resultadoAnterior}");
            Console.WriteLine($"Nuevo Valor = {nuevoValor}");
            Console.WriteLine($"Resultado = {resultado}");
            Console.WriteLine("======================================================");
        }
    }

    public class Calculadora
    {
        // estado //
        // campos //
        private double dato;
        private List<Operacion> operaciones = new List<Operacion>();
        // propiedades //
        public double Resultado
        {
            get => dato;
        }

        // comportamiento //
        // metodos //
        public void Sumar(double termino)
        {
            // valor anterior //
            double valorAnterior = dato;
            dato += termino;
            double nuevoValor = dato;
            Operacion operacion = new Operacion(valorAnterior,nuevoValor,TipoOperacion.Suma);
            operacion.resultado = dato;
            operaciones.Add(operacion);
        }

        public void Restar(double termino)
        {
            double valorAnterior = dato;
            dato -= termino;
            double nuevoValor = dato;
            Operacion operacion = new Operacion(valorAnterior,nuevoValor,TipoOperacion.Resta);
            operacion.resultado = dato;
            operaciones.Add(operacion);
        }

        public void Multiplicar(double termino)
        {
            double valorAnterior = dato;
            dato *= termino;
            double nuevoValor = dato;
            Operacion operacion = new Operacion(valorAnterior,nuevoValor,TipoOperacion.Multiplicacion);
            operacion.resultado = dato;
            operaciones.Add(operacion);
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                double valorAnterior = dato;
                dato /= termino;
                double nuevoValor = dato;
                Operacion operacion = new Operacion(valorAnterior,nuevoValor,TipoOperacion.Division);
                operacion.resultado = dato;
                operaciones.Add(operacion);
            }
            else
            {
                Console.WriteLine("no se puede dividir entre 0");
            }
        }

        // metodo para mostrar el historial //
        public void MostrarHistorial(){
            if(operaciones.Count != 0){
                for(int i = 0; i < operaciones.Count; i++){
                operaciones[i].MostrarOperacion();
                }
            }else{
                Console.WriteLine("el historial esta vacio");
            }
            Console.WriteLine("======================================================");
            
        }
        public void Limpiar()
        {
            double valorAnterior = dato;
            dato = 0;
            double nuevoValor = dato;
            Operacion operacion = new Operacion(valorAnterior,nuevoValor,TipoOperacion.Division);
            operacion.resultado = dato;
            operaciones.Add(operacion);
        }
    }
}