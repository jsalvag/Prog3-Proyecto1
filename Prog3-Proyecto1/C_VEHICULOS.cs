using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    class C_VEHICULOS:IEquatable<C_VEHICULOS>
    {
        private string
            placa,
            marca,
            modelo,
            condicion;
        private double
            km;

        private int
            anio;

        private bool
            estado;

        public C_VEHICULOS(string placa,string marca,string modelo,string condicion,string km,string anio)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.condicion = condicion;
            if (km == "")
                this.km = 0;
            else
                this.km = Convert.ToDouble(km);
            if (anio == "")
                this.anio = DateTime.Now.Year;
            else
                this.anio = Convert.ToInt16(anio);
            this.estado = true;
        }

        
        public bool Equals(C_VEHICULOS other)
        {
            if (this.placa == other.placa)
                return true;
            else
                return false;
        }
    }
}
