namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Pilas pilas = new Pilas(4);
                pilas.Agregar("A");
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Agregar("B");
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Agregar("C");
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Agregar("D");
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Agregar("E");
                Console.WriteLine("Eliminando elementos");
                pilas.Eliminar();
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Eliminar();
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Eliminar();
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Eliminar();
                Console.WriteLine(pilas.ObtenerDatos());
                pilas.Eliminar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
