namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //    Pilas pilas = new Pilas(4);
                //    pilas.Agregar("A");
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Agregar("B");
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Agregar("C");
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Agregar("D");
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Agregar("E");
                //    Console.WriteLine("Eliminando elementos");
                //    pilas.Eliminar();
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Eliminar();
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Eliminar();
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Eliminar();
                //    Console.WriteLine(pilas.ObtenerDatos());
                //    pilas.Eliminar();
                Colas colas = new Colas(5);
                colas.Agregar("A");
                Console.WriteLine(colas.ObtenerDatos());
                colas.Agregar("B");
                Console.WriteLine(colas.ObtenerDatos());
                colas.Agregar("C");
                Console.WriteLine(colas.ObtenerDatos());
                colas.Agregar("D");
                Console.WriteLine(colas.ObtenerDatos());
                colas.Agregar("E");
                Console.WriteLine(colas.ObtenerDatos());
                Console.WriteLine("eliminando datos: ");
                Console.WriteLine(colas.ObtenerDatos());
                colas.Eliminar();
                Console.WriteLine(colas.ObtenerDatos());
                colas.Eliminar();
                Console.WriteLine(colas.ObtenerDatos());
                colas.Eliminar();
                Console.WriteLine(colas.ObtenerDatos());
                colas.Eliminar();
                Console.WriteLine(colas.ObtenerDatos());
                colas.Eliminar();
                Console.WriteLine(colas.ObtenerDatos());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
