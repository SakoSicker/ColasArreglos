using System;
using System.Collections.Generic;
using System.Text;

namespace ColasArreglos
{
    internal class Colas
    {
        private string[] _cola;
        private int _tope;

        public Colas(int capacidad)
        {
            _cola = new string[capacidad];
            _tope = 0;
        }
        public void Agregar(string dato)
        {
            if (_tope == _cola.Length)
            {
                throw new Exception("La cola está llena.");
            }
            _cola[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("La cola está vacía.");
            }

            for (int i = 0; i < _tope - 1; i++)
            {
                _cola[i] = _cola[i + 1];
            }

            _tope--;
            _cola[_tope] = string.Empty; 
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < _tope; i++)
            {
                datos.AppendLine(_cola[i]);
            }
            return datos.ToString();
        }
    }
}
