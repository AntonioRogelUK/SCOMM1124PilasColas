namespace Arreglos
{
    internal class Colas
    {
        private string[] _arreglo;
        private int _inicio;
        private int _fin;

        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _inicio = 0;
            _fin = 0;
        }

        private bool EstaLleno()
        {
            return _fin == _arreglo.Length;
        }
        public void Agregar(string dato)
        {
            try
            {
                if (EstaLleno())
                {
                    throw new Exception("No hay espacio");
                }  

                _arreglo[_fin] = dato;
                _fin++;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool EstaVacio()
        {
            return _inicio == _fin;
        }
        public void Eliminar()
        {
            try
            {
                if (EstaVacio())
                {
                    throw new Exception("Esta vacio");
                }
                _arreglo[_inicio] = string.Empty;
                _inicio++;             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ObtenerDatos()
        {
            string acumulado = string.Empty;
            for (int i = _inicio; i < _fin; i++)
            {
                acumulado += _arreglo[i];
            }
            return acumulado;
        }
    }
}
