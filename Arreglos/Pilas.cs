namespace Arreglos
{
    internal class Pilas
    {
        private string[] _arreglo;
        private int _disponible;

        public Pilas(int elementos)
        {
            _arreglo = new string[elementos];
            _disponible = 0;
        }

        private bool EstaLleno()
        {
            //if (_disponible == _arreglo.Length) 
            //{
            //   return true;
            //}
            //return false;

            return _disponible == _arreglo.Length;
        }

        public void Agregar(string dato)
        {
            try
            {
                if (EstaLleno())
                {
                    throw new Exception("No hay espacio");
                }

                _arreglo[_disponible] = dato;
                _disponible++;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerDatos()
        {
            string acumulado = string.Empty;
            foreach (string dato in _arreglo)
            {
                acumulado += dato;
            }
            return acumulado;
        }

        private bool EstaVacio()
        {
            return _disponible == 0;
        }

        public void Eliminar()
        {
            try
            {
                if (EstaVacio())
                {
                    throw new Exception("Esta vacio");
                }

                _disponible--;
                _arreglo[_disponible] = string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
