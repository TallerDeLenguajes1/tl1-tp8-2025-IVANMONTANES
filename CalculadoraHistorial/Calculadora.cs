namespace EspacioCalculadora{
    public class Calculadora
    {
        // estado //
        // campos //
        private double dato;

        // propiedades //
        public double Resultado
        {
            get => dato;
        }

        // comportamiento //
        // metodos //
        public void Sumar(double termino)
        {
            dato += termino;
        }

        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("no se puede dividir entre 0");
            }
        }

        public void Limpiar()
        {
            dato = 0;
        }
    }
}