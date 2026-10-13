namespace ColasArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas cola = new Colas(5);

            cola.Agregar("Cliente A");
            cola.Agregar("Cliente B");
            cola.Agregar("Cliente C");

            Console.WriteLine("Estado inicial de la cola:");
            Console.WriteLine(cola.ObtenerDatos());

            cola.Eliminar();
            Console.WriteLine("Después de atender (eliminar) al frente:");
            Console.WriteLine(cola.ObtenerDatos());
        }
    }
}
