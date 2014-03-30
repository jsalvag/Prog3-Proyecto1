using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    public class C_ALQUILER
    {
        private string
            ciA,
            placaA;

        private DateTime
            f_alquiler;

        private double
            monto;

        private int
            dias;

        public C_ALQUILER(string ci,string placa,DateTime f_alquiler,double monto,int dias)
        {
            this.ciA = ci;
            this.placaA = placa;
            this.f_alquiler = f_alquiler;
            this.monto = monto;
            this.dias = dias;
        }

        public string[] datos()
        {
            string[] data = new string[5];
            data[0] = this.ciA;
            data[1] = this.placaA;
            data[2] = Convert.ToString(this.f_alquiler.Date);
            data[3] = Convert.ToString(this.dias);
            data[4] = Convert.ToString(this.monto);
            return data;
        }

        public string getPlaca() { return this.placaA; }

        public string getCedula() { return this.ciA; }

        public DateTime getFecha() { return this.f_alquiler; }

        public void setMonto(double m) { this.monto = m; }

        public void setDias(int d) { this.dias = d; }


    }
}
