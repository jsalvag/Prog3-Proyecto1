using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    public class C_VEHICULOS:IEquatable<C_VEHICULOS>
    {
        private string
            placa,
            marca,
            modelo,
            condicion;
        private double
            km,
            precioDia,
            precioSeguro;

        private int
            anio;

        private bool
            estado;

        public C_VEHICULOS(string placa,string marca,string modelo,string condicion,string km,string anio,string precioDia,string precioSeguro)
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
            if (precioDia == "")
                this.precioDia = 0;
            else
                this.precioDia =Convert.ToDouble(precioDia);
            if (precioSeguro == "")
                this.precioSeguro = 0;
            else
                this.precioSeguro = Convert.ToDouble(precioSeguro);
        }

        public bool Equals(C_VEHICULOS other)
        {
            if (this.placa == other.placa)
                return true;
            else
                return false;
        }

        public string getPlaca()
        {
            return this.placa;
        }

        public void setEstado(bool estado)
        {
            this.estado = estado;
        }

        public string[] datos()
        {
            string[] data = new string[9];
            data[0] = this.placa;
            data[1] = this.marca;
            data[2] = this.modelo;
            data[3] = Convert.ToString(this.anio);
            data[4] = Convert.ToString(this.km);
            data[5] = this.condicion;
            if(this.estado)
                data[6] = "Disponible";
            else
                data[6] = "En Alquiler";
            data[7] = Convert.ToString(this.precioDia);
            data[8] = Convert.ToString(this.precioSeguro);
            return data;
        }

        public bool comaprarCarros(string placa)
        {
            if (placa == this.placa)
                return true;
            return false;
        }

        public void setKm(double km) { this.km = km; }
    }
}
