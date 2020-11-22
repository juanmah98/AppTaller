using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaller
{
    class Vehiculos
    {
        private string estado;
        private string patente;
        private string nombreDuenio;
        private DateTime fechaIngreso;
        private float precio;
        public Vehiculos(string state, string pat, string duenio, DateTime fec, float price)
        {
            estado = state;
            patente = pat;
            nombreDuenio = duenio;
            fechaIngreso = fec;
            precio = price;
        }
        public string getEstado() { return estado; }
        public string getPatente() { return patente; }
        public string getDuenio() { return nombreDuenio; }
        public DateTime getFecha() { return fechaIngreso; }
        public float getPrecio() { return precio; }
        
    }
}
